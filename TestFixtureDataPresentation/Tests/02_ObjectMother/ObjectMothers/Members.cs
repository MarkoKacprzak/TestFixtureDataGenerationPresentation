using System;
using TestFixtureDataPresentation.Implementation.Models;

namespace TestFixtureDataPresentation.Tests._02_ObjectMother.ObjectMothers
{
    static partial class ObjectMother
    {
        public static class Members
        {
            public static Member Fred => new Member("Fred", State.Wa, new DateTime(1970, 1, 1));

            public static Member ForState(State state) => new Member("A Member", state, new DateTime(1970, 1, 1));

            public static Member WithAge(int age, DateTime now) => WithDateOfBirth(now.AddYears(-age));

            public static Member WithDateOfBirth(DateTime dob) => new Member("A Member", State.Wa, dob);

            public static Member InWaWithAge(int age, DateTime now) => new Member("WA member", State.Wa, now.AddYears(-age));

            public static Member WithAgeAndState(int age, DateTime now, State state) => new Member("A Member", state, now.AddYears(-age));
        }
    }
}
