# Resource Documentation: Appointing Method

## 1. Overview
An `AppointingMethod` is a concept used to define the method by which appointments are scheduled within a specific `Schedule`. The purpose of an `AppointingMethod` is to provide clarity and standardization in distinguishing between different approaches to appointment scheduling, facilitating interoperability between systems. There are two primary types of Appointing:
- **Untimed Appointing Method:**
    This method is used for Schedules where appointments are not bound to specific timeslots. Patients are invited to attend within a broader timeframe (e.g., between 09:00 AM and 5:00 PM), often in a "drop-in" or "walk-in" style. This approach provides flexibility for patients and is commonly used for events such as vaccination clinics or open-access consultations.

 - **Timed Appointing Method:**
    This method applies to Schedules that are divided into precise timeslots, each allocated to specific appointments. Patients are assigned a dedicated time, allowing for a structured and orderly flow of appointments.

The concept of an `AppointingMethod` is not currently modeled explicitly within FHIR (Fast Healthcare Interoperability Resources). To fill this gap, reference data for this concept is sourced from the Welsh Immunisation System (WIS) and the Children and Young Persons Integrated System (CYPrIS). These sources provide foundational terminology and classifications that can be standardized for broader use.

We are hoping that the resource and its elements should be named in a way that reflects their purpose clearly. This ensures alignment with ubiquitous language principles, enabling better communication across teams and systems.

---

## 2. Reference Data
### 2.1. Source
The following resources helped inform the design of this resource, alongside any valuesets used for populating the data:
- The `AppointingMethod` Value Set should correlate to the existing reference data in the Welsh Immunisation System/Children and Young Persons Integrated System.


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
- Referenced in the `Schedule` resource via the `AppointingMethodId` field on `Schedule`
---
## 4. Context and Usage
### 4.1. Scenarios
- Used to indicate the methodolgy used for `Timeslot` generation within a `Schedule`, such as if a `Timeslot` should be assigned as a specific timeslice, or as an open drop-in clinic.

### 4.2. Constraints
- The code field must be unique across the table to avoid duplicate route entries.
- The display field should not allow null values.
- The definition field should not allow null values.
- The system field should default to the FHIR system URI and be non-null. ("http://wis.wales.nhs.uk/wis")
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