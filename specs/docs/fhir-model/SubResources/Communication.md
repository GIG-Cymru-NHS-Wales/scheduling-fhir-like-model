# Resource Documentation: Communication

# Status: 🟠 In Review

> This item is currently under review. Please check back later for updates or provide feedback if necessary.


## 1. Overview
Within the National Immunisation Framework, a `Communication` is a record of clinical/business level information being transmitted or shared. Within the initial workflows, this relates to correspondence relating to an `Appointment`. (E.g, letter communicating a record of booking/cancellation) The use of the resource is to track meaningful information relating to the configuration parameters used to send the corespondence, and is strongly based on the `Communication` resource outlined in FHIR.

To ensure consistent and accurate recording of records of `Communication`s across different healthcare systems, it is essential that we standardise the data set used for recording. Our aim is to leverage the FHIR data models (specifically the `Communication`) put together via the Information Standards team, and create a model that could easily be transformed into the shape that they've set out. By doing this, we can ensure that consuming applications are storing data in a reliable, reasonable and interpretable way, which will be universally recognised. This approach will enhance data quality, facilitate easy interoperability with other systems, and provide a basis for universally understandable reporting and analytics.


## 1.1 Why is Communication not a root aggregate/it's own service?
While `Communication`s may eventually be moved into their own service as part of a long-term architectural evolution, in the current design, it makes sense for a `Communication` to exist as part of a single `Appointment` resource as an aggregate. This is because Communications derive their meaning entirely from the context of an `Appointment`. For instance, if an `Appointment` were to be deleted, its associated `Communication`s would no longer hold relevance and would also be removed. Furthermore, a `Communication` record is inherently tied to a specific `Appointment`—without this association, the `Communication` itself would lack purpose or context

---

## 2. Reference Data
### 2.1. Source
The following resources helped inform the design of this resource, alongside any valuesets used for populating the data:
- Based on the [Communication - HL7](https://build.fhir.org/communication.html) model.
- The `AppointmentStatusId` should correlate to an associated `EventStatus` value set defined via [EventStatus - HL7](https://build.fhir.org/valueset-event-status.html).
- The `StatusReasonId` should correlate to an associated `CommunicationNotDoneReason` value set defined via [CommunicationNotDoneReason - HL7](https://build.fhir.org/valueset-communication-not-done-reason.html)
- The `CommunicationCategoryId` should correlate to an associated `CommunicationCategory` value set definied via [CommunicationCategory - HL7](https://build.fhir.org/valueset-communication-category.html).
- The `PriorityId` should correlate to an associated `RequestPriority` value set deined via [RequestPriority - HL7](https://build.fhir.org/valueset-request-priority.html).
- The `MediumId` should correlate to an assocaited `ParticipationMode` value set defined via [Participation Mode - HL7](http://terminology.hl7.org/6.1.0/ValueSet-v3-ParticipationMode.html).
- The `TopicId` should correlate to an associated `CommunicationTopic` value set defined via [CommunicationTopic - HL7](https://build.fhir.org/valueset-communication-topic.html).
- 

### 2.2. Adaptations
The following changes were made to facilitate the design into our own local implementation:
- The `instantiatesCanonical` (& associated `instantiatesUrl`) resource has been ommitted, as the underlying referenced resource doesn't seem to map to our workflows. (Not marked as mandatory in FHIR)
- The `basedOn` resource has been ommitted, as the underlying referenced resources doesn't seem to be map to our workflows. (Not marked as mandatory in FHIR.)
- The `partOf` & `about` fields aren't present in the model, however, both can be reflected via the associated `AppointmentId` pending further investigation in the most appropriate resource.
- `inResponseTo` has been ommitted, as Communications are currently singular, and don't follow a bi-directional functionality.
- `status` has been changed to the `StatusId` field.
- `statusReason` has been changed to a singular `StatusReasonId` field, associated with a `StatusReason` reference data resource, that can further expand into the `CodeableConcept` shape.
- `category` has been changed to a singular `CommunicationCategoryId` field, associated with a `CommunicationCategory` reference data resource, that can further expand into the `CodeableConcept` shape.
- `priority` has been changed to the `StatusId` field.
- `medium` has been changed to a singular `MediumId`  field, associated with a `ParticipationMode` reference data resource, that can further expand into the `CodeableConcept` shape.
- `subject` & `recipient` has been changed to the singular `PatientNhsNumber` field, that can be further expanded via the `Demographics` microservice dataset. (See `Patient` resource.)
- `topic` has been changed to a singular `TopicId`  field, associated with a `CommunicationTopic` reference data resource, that can further expand into the `CodeableConcept` shape.
- `encounter` field has been ommitted, as this can be inflected via the underlying `Appointment` resource.
- `receieved` field has been ommited, as the use of the Notify service doesn't easily allow us to update this field. (NIF works more in a 'fire and forget' way.)
- `sender` has been ommitted, but eventually will reference an `Organisation` resource when the Location service is fully modelled.
- `reason` has been ommitted, as the underlying `SnomedCTClinicalFindings` data set doesn't neatly align with the work flows.
- `payload` has been ommitted, as this data set is resourced within the Notify service.
- An additional `AppointmentId` field has been added, as a way to link to an underlying appointment.
- An additional `EmsgId` field has been added, as a temporary measure until correspondence has been fully rewritten.


- ---
## 3. Resource Structure
### 3.1. Fields
Document each field in the resource, its data type, its purpose, and its alignment with FHIR (if applicable).


| **Field Name**            | **Data Type**       | **Purpose/Meaning**                                                                                  | **FHIR Alignment**                               |
|---------------------------|---------------------|------------------------------------------------------------------------------------------------------|-------------------------------------------------|
| `Identifier`              | `RAW(16)`           | Unique identifier for the communication record.                                                      | Matches FHIR's `Communication.id`.              |
| `StatusId`                | `NVARCHAR2(2000)`   | Indicates the status of the communication (e.g., `active`, `in-progress`).                             | Matches FHIR's `Communication.status`.          |
| `StatusReasonId`          | `NVARCHAR2(25)`     | Reason associated with the communication status if set to `not-completed`.                                                     | Matches FHIR's `Communication.statusReason`.    |
| `CommunicationCategoryId` | `NVARCHAR2(15)`     | Category or type of communication (e.g., `email`, `SMS`).                                            | Matches FHIR's `Communication.category`.        |
| `PriorityId`              | `NVARCHAR2(10)`     | Priority level of the communication.                                                                 | Matches FHIR's `Communication.priority`.        |
| `MediumId`                | `NVARCHAR2(15)`     | Medium or mode of communication (e.g., `phone`, `portal`).                                           | Matches FHIR's `Communication.medium`.          |
| `PatientNhsNumber`        | `NVARCHAR2(450)`    | NHS Number identifying the patient associated with the communication.                                | Matches FHIR's `Communication.subject` (Patient). |
| `TopicId`                 | `NVARCHAR2(20)`     | Topic or context of the communication.                                                               | Matches FHIR's `Communication.topic`.           |
| `EmsgId`                  | `NUMBER(19,0)`      | Identifier linking to the message sent through the external messaging system.                        | Custom field; no direct FHIR equivalent.        |
| `AppointmentId`           | `RAW(16)`           | Identifier for the appointment associated with this communication.                                   | Matches FHIR's `Communication.encounter` (indirectly via Appointment). |
| `Sent`                    | `TIMESTAMP(7)`      | Date and time when the communication was sent.                                                       | Matches FHIR's `Communication.sent`.            |
| `Note`                    | `NVARCHAR2(250)`    | Additional information or comments about the communication.                                          | Matches FHIR's `Communication.note`.            |
| `ConcurrencyToken`        | `TIMESTAMP(6)`      | Used for concurrency control to prevent conflicting updates.                                         | Custom field; no direct FHIR equivalent.        |
| `StatusId`           | `NVARCHAR2(20)`     | Status of the associated event (e.g., `active`, `completed`).                                         | Matches FHIR's `Communication.eventStatus`.     |



### 3.2. Relationships
- Links to an `Appointment` resource via the `AppointmentId` field on `Communication`.
- Links to a `CommunicationCategory` reference data resource via the `CommunicationCategoryId` field on `Communication`.
- Links to a `CommunicationNotDoneReason` reference data resource via the `StatusReasonId` field on `Communication`.
- Links to a `CommunicationTopic` reference data resource via the `TopicId` field on `Communication`.
- Links to an `EventStatus` reference data resource via the `EventStatusId` field on `Communication`.
- Links to a `ParticipantMode` reference data resource via the `MediumId` field on `Communication`.
- Links to a `RequestPriority` reference data resource via the `PriorityId` field on `Communication`.
 
---
## 4. Context and Usage
### 4.1. Scenarios
- Used to record a record of an `Appointment Letter`.
- Used to record a record of a `Appointment Reminder Letter`.
- Used to record a record of an `Appointment Cancellation Letter`.
- Used to record a record of an `Opt Out Notification Letter`.

### 4.2. Constraints
- The `Identifier` field must be globally unique to ensure no ambiguity with other records.
- The `StatusId` field cannot be null.
- The `MediumId` field cannot be null.
- The `PatientNhsNumber` field cannot be null.
- The `AppointmentId` field cannot be null and must reference an existing `Appointment` resource.
- The `CommunicationCategoryId` field must reference a valid entry in the `CommunicationCategory` reference data, if provided.
- The `StatusReasonId` field must reference a valid entry in the `CommunicationNotDoneReason` reference data, if provided.
- The `TopicId` field must reference a valid entry in the `CommunicationTopic` reference data, if provided.
- The `EventStatusId` field must reference a valid entry in the `EventStatus` reference data, if provided.
- The `PriorityId` field must reference a valid entry in the `RequestPriority` reference data, if provided.
- The `ConcurrencyToken` field cannot be null to ensure data consistency during updates.
- The `EmsgId` field cannot be null and must be unique.
---

## 5. Version History

| **Version** | **Date**       | **Changes**                                | **Author**          |
|-------------|----------------|--------------------------------------------|---------------------|
| 1.0         | 2024-11-16     | Initial version.                           | Joel Andrew Howe       |


---

## 6. Legacy Mapping
This section describes how the fields in the new resource map to the legacy `EMSG_QUEUE` table. The goal is to ensure clarity in how existing data can be transitioned or integrated with the new structure.

### 6.1. Mapping Table - IMM_CHILD_COURSES_GIVEN_WIS
| **New Field**               | **Legacy Field**            | **Transformation/Notes**                                                                                      |
|-----------------------------|-----------------------------|----------------------------------------------------------------------------------------------------------------|
| `Identifier`                | Not applicable      | Data has been normalised, so now a separate resource and requires a new Guuid identifier.                                            |
| `ImmunisationId`            | `PK_FK_IMM_GIVEN_ID`           | Maps directly. Need to ensure we're using the new Guuid values for Immunisation results.                       |
| `Date`                      | Not applicable.                                            | Not Applicable. |
| `AdverseReactionTypeId`     | `ADVERSE_REACTION_TYPE_ID`  | Maps directly. Ensure that the ID references the correct `AdverseReactionType` table, and is usng the new SNOMED CT IDs.                          |
| `Note`                      | Not applicable.                                            | Not Applicable. |
| `Reported`                  | Not Applicable               | Always set this to 'Y'                         |
| `MedicalAttentionRequired`  | Not Applicable   | Set this to null       |
| `Recorded`                  | Not applicable.                                            | Not Applicable. |
| `ConcurrencyToken`          | `CONCURRENCY_TOKEN`         | Maps directly. Default to a timestamp as defined.                                                              |

---