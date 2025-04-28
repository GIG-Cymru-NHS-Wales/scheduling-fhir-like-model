# Domain Layer
## Overview
The `Scheduling project` follows the principles of Onion Architecture, so that we can ensure there is a clear separation of concerns, testability and maintainability. The `Domain layer`, which acts as the central point of the architecture, contains the core business model and is the foundation upon which the rest of the application is built.

This document aims to provide an overview of the two key projects within the `Domain layer`, the `Domain` project, and the `Domain.Types` project.

## Domain Project
### Purpose
The `Domain` project contains the root domain models that encapsulate the core entities for the Scheduling system. These models have used the FHIR (Fast Healthcare Interoperability Resources) standards, which is widely used in healthcare for exchanging electronic health records. It's important to note that these models are 'FHIR-Like', and not 1-for-1 with the FHIR model, as there are specific use cases that NIF may require, that aren't covered by the FHIR standards. 

By moving towards a FHIR-like structure, the hope is that we can build the system with interoperability baked in from the outset, which will allow us to easily map our data to FHIR resources, and share with other systems using the FHIR standards.

In future, the thought is that we can use a service like FHIRly, to expose these data items with other systems, such as NDR.

### Key Features
- **Root Domain Models** - Primary business entities represented by C# classes, that depict the core concepts within the `Scheduling` domain. For example, these could be Appointments, Schedule's and Appointment Responses.
- **Domain Logic** - Core validation logic should be implemented here to ensure the integrity of the domain models. Whilst this currently isn't in place, the thought is to use Fluent Guard Clauses to incorporate this core logic.
- **FHIR-Like Data Structures** - Models are designed to be as close to the equivalent FHIR-models as possible, to ensure that we can easily facilitate compatibility and interoperability with other healthcare systems.

### Example File Structure
```
Scheduling.Domain/  
├── Appointment.cs  
├── AppointmentStatus.cs  
```
### Usage
The `Domain project` should be referenced by the `Application layer`, to interact with the core business logic and entities. It shouldn't depend on any external libraries or frameworks, and should remain isolated and focused purely on domain logic. 


## Domain.Types Project
### Purpose
The `Domain.Types` project is dedicated to creating strongly typed values, enumerations, and custom types that enhance the type safety and expressiveness within the domain models. By using strongly typed values, the project ensures that only valid data is used throughout the application, reducing the likelihood of bugs, and improving code clarity.

### Key Features
- **Strongly Typed Values** - Custom types that encapsulate primitive types (e.g., AppointmentStatusId) with additional validation, or domain-specific logic.
- **Enumerations** - Enumerations are predefined sets of values, ensuring consistency and reducing the risk of invalid data. Usually, these are used to represent slow-moving reference data values, that we do not believe will change.
- **Custom Types** - Types that encapsulate more complex domain concepts that do not fit into the standard data types.

### Example File Structure
```
Scheduling.Domain.Types/  
├── Ids/  
	└─── AppointmentStatusId.cs  
├── Lookups/  
	└─── AppointmentStatusEnum.cs  
├── Types/  
	└─── ReallyComplexStructure.cs
```
### Usage
The `Domain.Types` project should be referenced by the Domain project to enforce strong typing and ensure that domain models are robust and reliable. It can also be referenced by other layers that require access to these types

## Best Practices
- **Separation of Concerns** - The `Domain` and `Domain.Types` projects should be focused solely on their responsibilities, domain logic and type safety.
- **Ubiquitous Language** - The language used in the `Domain layer` should follow the best practices for Domain Driven Design. Terminology, and naming of entities should be consistent with those used by the business analysts. This will ensure that communication is clear, and can easily be translated into development requirements.
- **Immutability** - When possible, the domain models and types should remain fairly static and immutable, to ensure that unintended side effects are prevented.
- **Validation** - Whilst not present now, we should put core validation logic within the strongly typed values and domain models, to ensure we maintain a high degree of data integrity.
- **Testability** - Any validation logic within the strongly typed values and domain models should be backed by clear, robust and focused unit tests, to ensure they behave as expected under different conditions.