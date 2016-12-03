using TestFixtureDataPresentation.Implementation.Models;

namespace TestFixtureDataPresentation.Tests._02_ObjectMother.ObjectMothers
{
    static partial class ObjectMother
    {
        public static class Demographics
        {
            public static Demographic AllMembers => Demographic.AllMembers;

            public static Demographic WithStateAndAgeRange => new Demographic(State.Wa, 18, 19);

            public static Demographic ForState(State state) => new Demographic(state, null, null);

            public static Demographic WithMinimumAge(int minimumAge) => new Demographic(null, minimumAge, null);

            public static Demographic WithMaximumAge(int maximumAge) => new Demographic(null, null, maximumAge);
        }
    }
}
