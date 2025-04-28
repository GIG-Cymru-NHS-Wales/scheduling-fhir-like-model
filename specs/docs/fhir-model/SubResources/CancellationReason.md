# Resource Documentation: Cancellation Reason

## 1. Overview
`CancellationReason`s are used as a way of documenting the justification of cancelling a `Appointment`. These can be incredibly useful for analytical data, to understand the reasons that `Appointment`s are cancelled, such as if they are cancelled by Providers, or due to the `Patient`s objections to being `Immunised`.

To ensure consistent and accurate recording of the `CancellationReason`s for an appointment across different healthcare systems, it is essential that we standardise the reference data for indicating the `CancellationReason`s. (E.g. booked) Leveraging the FHIR value set codes within the FHIR value set will allow our system to align with international healthcare standards, and make it easily interoperable. We can create the `CancellationReason` table that stores this reference data, and allow our consuming applications to reliably store and retrieve this information, enabling users to document this data in a way that is universally recognised. This approach will enhance data quality, support easier interoperability with other systems, and provide a basis for universally understandable reporting and analytics.

---

## 2. Reference Data
### 2.1. Source
The following resources helped inform the design of this resource, alongside any valuesets used for populating the data:
- The `CancellationReason` Value Set should correlate to the[CancellationReason - HL7](https://build.fhir.org/valueset-appointment-cancellation-reason.html).


### 2.2. Adaptations
The following changes were made to facilitate the design into our own local implementation:
- The addition of a `Definition` field, to allow for differentiating the display value from the underlying Snomed descriptor. (As often they can be a bit too verbose)
- The addition of a `System` field
- The addition of an `IsActive` boolean flag, used for controlling the reference data used within the localised systems. Primarily used as not all options are currently relevant in the scope of Winter Respiratory, but these can be dynamically changed at any point.
- The addition of a `DisplayOrder` integer field, used to indicate the order in which the reference data should display within a dropdown. This will be used locally within an application to ensure that data is ordered in an appropriate way.
- ---
## 3. Resource Structure
### 3.1. Fields
Document each field in the resource, its data type, its purpose, and its alignment with FHIR (if applicable).

| **Field Name**      | **Data Type**   | **Purpose/Meaning**                                                | **FHIR Alignment**                          |
|----------------------|-----------------|----------------------------------------------------------------------|---------------------------------------------|
| `code`                | `string`        | Unique identifier for the resource.                                | Direct match to FHIR's `code`.                |
| `display`              | `string`        | Represents the text that should display when reflecting this resource in a UI. This value should be it's most simplistic and humanly readable form.                                | Matches FHIR's `display`.                      |
| `definition`         | `string`          | A descriptor explaining the qualified definition of the type. Used if extra context is required.                                       | Matches FHIR's `definition`.                 |
| `system`      | `uri`        | Specifies the source of the reference data value. This ensures there is no ambiguity in the case of a code being shared across multiple value sets.        | Matches FHIR's `system`.    |
| `isactive`            | `boolean`       | Indicates if the reference data should display on a consuming system.  | Custom field; no direct FHIR equivalent
| `displayorder`            | `integer`       | Indicates the order that the value should display in a consuming system.                           | Custom field; no direct FHIR equivalent       |

### 3.2. Relationships
- Referenced in the `Appointment` resource via the `CancellationReasonId` field on `Appointment`.
---
## 4. Context and Usage
### 4.1. Scenarios
- Used to indicate the cancellation reason of an `Appointment` event.

### 4.2. Constraints
- The code field must be unique across the table to avoid duplicate route entries.
- The display field should not allow null values.
- The definition field should not allow null values.
- The system field should default to the FHIR system URI and be non-null.("http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason")
- The `DisplayOrder` should be populated for any display orders.
- The `IsActive` field should be set to Y/N, to indicate if the reference data is active.
---

## 5. Version History

| **Version** | **Date**       | **Changes**                                | **Author**          |
|-------------|----------------|--------------------------------------------|---------------------|
| 1.0         | 2024-11-16     | Initial version.                           | Joel Andrew Howe       |


---

## 6. Legacy Mapping
This section describes how the fields in the new resource map to the legacy `Adverse_Reaction_Types` table. The goal is to ensure clarity in how existing data can be transitioned or integrated with the new structure.

### 6.1. Mapping Table
| **New Field**       | **Legacy Field**            | 
---