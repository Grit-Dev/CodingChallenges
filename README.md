# C# Coding Challenges

This repository is my personal C# practice space for strengthening programming fundamentals, improving problem-solving skills, and gradually progressing into object-oriented and practical C# development exercises.

The goal is not simply to complete challenges once. The goal is to practise solving problems from scratch, revisit weaker areas, debug mistakes, improve confidence, and build a stronger understanding of how C# code works.

This repository supports my wider software development preparation, alongside separate projects for API development, SQL practice, and portfolio work.

## Purpose

The main focus of this repository is to practise and reinforce:

- loops and conditionals
- strings, characters, arrays, and collections
- counters and comparison logic
- nested loops
- frequency counting
- duplicate detection
- edge case handling
- parsing with `Split`, `Trim`, and `TryParse`
- manual searching and comparison logic
- debugging and problem solving
- classes and objects
- constructors and properties
- working with collections of objects
- encapsulation and private setters
- object responsibilities and interactions
- helper methods and refactoring
- result objects and request-style objects
- practical C# tasks involving JSON and models
- explaining code clearly

As the repository progresses, it will continue moving into more practical C# concepts such as:

- composition
- inheritance
- polymorphism
- abstraction
- interfaces
- service-style class design
- unit testing with xUnit
- exception handling
- basic algorithms and data structures
- recursion basics
- timed interview-style coding drills

API, controller, SQL, and full application work are practised separately in dedicated projects.

## Approach

For many exercises, I intentionally solve the core problem manually rather than relying on methods that directly perform the main task.

Depending on the challenge, I may avoid shortcuts such as:

- `Reverse()`
- `Max()`
- `Min()`
- `Sort()`
- `Distinct()`
- LINQ methods such as `Where()`, `Select()`, `Count()`, and `Sum()`

This is intentional and allows me to practise the underlying logic using:

- loops
- conditions
- counters
- variables
- lists
- nested iteration
- state tracking
- manual comparisons

Normal C# and .NET features are still used where appropriate, including methods such as:

- `Contains()`
- `IndexOf()`
- `Substring()`
- `Split()`
- `Trim()`
- `StringBuilder`
- `JsonSerializer`
- character helper methods

## Tooling

GitHub Copilot and AI code completion are disabled while solving the challenges.

I use normal development tools such as:

- IntelliSense
- compiler errors
- breakpoints
- the Visual Studio debugger

These are part of the learning process and help me inspect values, understand execution flow, identify mistakes, and debug solutions independently.

AI may be used after I have attempted or completed a challenge to review the finished solution, suggest cleaner C# conventions, identify edge cases, or help refactor code while preserving the original logic.

## Repository Structure

The repository is organised into learning phases so progress can be tracked over time.

```text
Challenges/
├── Phase_01_Fundamentals/
│   ├── ChallengeSolutions.cs
│   └── ChallengeSolutionsRunner.cs
│
├── Phase_02_OOP/
│   ├── Shared/
│   │   ├── BuyCardRequest.cs
│   │   ├── Card.cs
│   │   ├── CardCollection.cs
│   │   ├── CardShop.cs
│   │   ├── CardShopResult.cs
│   │   ├── Player.cs
│   │   ├── SellCardRequest.cs
│   │   └── ShopTransaction.cs
│   │
│   ├── CardShopCompositionChallenges.cs
│   ├── CardShopOperationResultChallenges.cs
│   ├── CardShopRequestObjectChallenges.cs
│   ├── CardShopRequestObjectCleanupChallenges.cs
│   ├── CardShopResultRefactorChallenges.cs
│   ├── CardShopTransactionHistoryChallenges.cs
│   ├── CardShopTransactionReportsChallenges.cs
│   └── PhaseTwoChallengeRunner.cs
│
└── Phase_03_Practical_Challenges/
    ├── JsonDataSanitizerRunner.cs
    ├── PeopleData.cs
    ├── Person.cs
    ├── PersonalDataRedactor.cs
    └── PersonalDataRedactorTests.cs
```

## Phase 1 — Fundamentals

This phase focuses on core C# problem solving.

Topics include:

- loops
- arrays
- strings
- lists
- counters
- conditions
- parsing
- duplicate detection
- simple state tracking
- edge cases

This phase is mostly in maintenance mode, but similar challenges are still used to keep fundamentals sharp.

## Phase 2 — Object-Oriented Programming

This phase focuses on learning OOP through a small card-shop style system.

Topics include:

- classes and objects
- properties and constructors
- encapsulation
- private setters
- object collaboration
- inventory and owned-card collections
- buy and sell flows
- transaction history
- report methods
- result objects
- request-style objects
- helper methods
- refactoring

The goal is to practise business logic in plain C# before moving into larger application patterns.

## Phase 3 — Practical C# Challenges

This phase introduces more realistic coding tasks that combine multiple skills.

The current practical challenge is:

```text
JSON Personal Data Redactor
```

This challenge practises:

- reading acceptance criteria
- planning before coding
- JSON deserialization
- C# models
- string redaction rules
- helper methods
- serialization
- edge case handling
- unit-test thinking

Example responsibilities include:

- converting names to initials
- extracting a city from an address
- masking mobile numbers
- masking email addresses
- returning updated JSON

## Current Status and Roadmap

This repository is a living practice project. Each phase is revisited as needed to strengthen weak areas, improve code quality, and add tests.

### Current Focus

The current focus is:

- reinforcing C# fundamentals through regular coding challenges
- improving object-oriented design through small business-logic exercises
- practising practical C# tasks that combine models, JSON, helper methods, debugging, and tests
- gradually moving from manual console checks toward xUnit tests
- building confidence explaining code clearly in an interview setting

The most recent practical challenge is the **JSON Personal Data Redactor**, which is being used to practise:

- reading acceptance criteria
- planning before coding
- creating C# models for JSON
- deserializing JSON into objects
- applying redaction rules through helper methods
- serializing objects back into JSON
- adding unit tests for expected behaviour and edge cases

### Planned Progression

The next areas planned for this repository are:

- more xUnit tests for practical challenges
- refactoring existing solutions for readability
- composition and separation of responsibility
- inheritance and polymorphism
- abstraction, abstract classes, and interfaces
- service-style class design in plain C#
- basic algorithms and data structures
- recursion basics
- timed interview-style coding drills

API, controller, SQL, and full application work are practised separately in dedicated projects.

## Testing

This repository is gradually moving from manual console checks toward proper xUnit tests.

Manual checks are still useful while learning because they make it easy to see output quickly, but the long-term goal is to cover important behaviours with real tests.

Test focus areas include:

- expected success cases
- edge cases
- invalid input
- empty input
- multiple records
- redaction rules

## Learning Goals

The long-term goals of this repository are to:

- become sharper at solving C# coding problems
- improve confidence with loops, strings, arrays, lists, and objects
- understand OOP through practical examples
- write cleaner, smaller, easier-to-explain methods
- practise debugging instead of guessing
- move from console checks toward proper automated tests
- build confidence explaining code in interviews
- gradually introduce algorithms, data structures, recursion, and testable design

## Notes

This repository is intentionally focused on learning and deliberate practice.

Some solutions may be revisited, refactored, or expanded over time as my understanding improves. The aim is to keep the code clear, practical, and easy to explain rather than overengineered.

Separate repositories and practice areas are used for:

- ASP.NET Core API development
- SQL practice
- larger portfolio projects