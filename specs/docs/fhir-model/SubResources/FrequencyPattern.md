# Resource Documentation: Frequency Pattern

## 1. Overview
The concept of a `FrequencyPattern` is utilized to specify how often a given `Schedule` recurs. Examples of such recurrence patterns include intervals like `Weekly`, `Fortnightly`, `Monthly`, or `Yearly`. This plays a crucial role in defining the temporal nature of a `Schedule`, especially in contexts where the reptition patterns are critical.

However, the `FrequencyPattern` does not exist with any pre-existing properties defined within the FHIR `Schedule` resource. To address this gap, a Custom Extension needs to be developed in order to incorporate this functionality. This Custom Extension will leverage the existing reference data already established within the Welsh Immunisation System, and the Children and Young Persons Integrated system ensuring consistency and alignment with existing standards in these systems.

These systems currently allow for the following frequency patterns:
- `Weekly`
- `Fortnightly`
- `4-Weekly`
- `Monthly`

---

## 2. Reference Data
### 2.1. Source
The following resources helped inform the design of this resource, alongside any valuesets used for populating the data:
- The `FrequencyPattern` Value Set should correlate to the existing reference data in the Welsh Immunisation System/Children and Young Persons Integrated System.


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
- Referenced in the `Schedule` resource via the `FrequencyPatternId` field on `Schedule`
---
## 4. Context and Usage
### 4.1. Scenarios
- Used to indicate the frequency that a `Schedule` should recur, used for the generation of associated `Timeslot`s.

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
