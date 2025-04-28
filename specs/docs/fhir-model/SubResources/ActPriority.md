# Resource Documentation: Communication Category

## 1. Overview
The `ActPriority` concept serves as a classification system to define the level of urgency associated with a specific `Act`. Within the context of an `Appointment`, `ActPriority` is particularly important for indicating how critical it is for a patient to receive a vaccination. This ensures that healthcare providers can prioritize patients effectively based on their individual circumstances and clinical needs.

For instance, consider a patient who is immunosuppressed. Their health condition may require that they receive a vaccination as soon as possible to reduce the risk of severe illness. In such cases, the `ActPriority` would be set to asap, reflecting the need for immediate action. Conversely, for patients without such urgent clinical considerations, vaccinations may be scheduled under a priority of Routine, denoting standard timing without immediate urgency.

This categorization allows healthcare systems to align appointment scheduling with clinical priorities, ensuring that resources are allocated efficiently and that patients with the greatest need are attended to promptly. By integrating the ActPriority concept into appointment management processes, healthcare providers can enhance patient outcomes while maintaining an organized and effective scheduling framework.

To ensure consistent and accurate recording of the priority of an `Appointment` across different healthcare systems, it is essential that we standardise the reference data for indicating the `ActPriority`s. (E.g. reminder) Leveraging the FHIR value set codes within the FHIR value set will allow our system to align with international healthcare standards, and make it easily interoperable. We can create the `ActPriority` table that stores this reference data, and allow our consuming applications to reliably store and retrieve this information, enabling users to document this data in a way that is universally recognised. This approach will enhance data quality, support easier interoperability with other systems, and provide a basis for universally understandable reporting and analytics.

---

## 2. Reference Data
### 2.1. Source
The following resources helped inform the design of this resource, alongside any valuesets used for populating the data:
- The `ActPriority` Value Set should correlate to the[ActPriority - HL7](https://terminology.hl7.org/6.1.0/ValueSet-v3-ActPriority.html).


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
- Referenced in the `Communication` resource via the `CommunicationCategoryId` field on `Communication`
---
## 4. Context and Usage
### 4.1. Scenarios
- Used to record the category that the notification belongs too.

### 4.2. Constraints
- The code field must be unique across the table to avoid duplicate route entries.
- The display field should not allow null values.
- The definition field should not allow null values.
- The system field should default to the FHIR system URI and be non-null.("http://terminology.hl7.org/CodeSystem/v3-ActPriority")
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