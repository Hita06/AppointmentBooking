# Test Strategy

## 1. Purpose

The purpose of this test strategy is to define how testing will be performed for the Appointment Booking System. It ensures that the application meets its functional requirements and that defects are identified before the software is released.

## 2. Scope of Testing

Testing includes:

- Doctor validation
- Patient validation
- Appointment booking
- Appointment cancellation
- Doctor slot reservation and release
- Exception handling
- Unit testing of business logic

## 3. Out of Scope

The following are not included in this project:

- Database testing
- Network testing
- Performance testing
- Security testing
- Mobile application testing

## 4. Test Levels

The following test levels will be used:

- Unit Testing
- Integration Testing
- System Testing

## 5. Test Types

The following test types will be performed:

- Validation Testing
- Regression Testing
- Usability Testing
- Functional Testing

## 6. Test Environment

Testing will be completed using:

- Visual Studio 2022 for Mac
- .NET 7
- MSTest Framework
- GitHub repository

## 7. Tools

The following tools are used:

- Visual Studio 2022 for Mac
- MSTest
- Git
- GitHub
- GitHub Copilot (used only for suggestions and reviewed before use)

## 8. Defect Management Approach

Defects will be identified through testing, recorded, fixed, and tested again before the code is committed.

## 9. Entry Criteria

Testing can begin when:

- Code has been implemented
- The project builds successfully
- Test cases have been prepared

## 10. Exit Criteria

Testing is complete when:

- All unit tests pass
- Critical defects are fixed
- The booking and cancellation features work correctly

## 11. Risks and Mitigation

|               Risk               |                Mitigation                |
|----------------------------------|------------------------------------------|
| Invalid input causes failures    | Validate all user input                  |
| Changes break existing features  | Perform regression testing               |
| Bugs remain undetected           | Create sufficient unit tests             |
| Incorrect appointment slot count | Test booking and cancellation thoroughly |
