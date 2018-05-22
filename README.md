# Mocking

Replacing the actual dependancy that would be used at Production with test-time-only version that enables easier isolation of the code we want to test.

# Test Double
"Test Double is generic term for any case where you replace production object for testing purpose." - Martin Fowler

1. Fakes : Working Implementation of the dependancies. (EF Core, In-Memory provider)
2. Dummies : Passed around the test instead of actual objects
3. Stubs : Provide Answers to the calls.
4. Mocks : Expect/Verify calls.
