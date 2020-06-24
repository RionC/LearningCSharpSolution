using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class CollectionsAndArrays
    {
        [Fact]
        public void UsingAnOldSkoolArrayList()
        {
            var favoriteNumbers = new ArrayList(); // not type safe
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(20);
            favoriteNumbers.Add(42);
            favoriteNumbers.Add(108);

            Assert.Equal(9, favoriteNumbers[0]);
            Assert.Equal(108, favoriteNumbers[3]);
            favoriteNumbers[0] = 10;
            Assert.Equal(10, favoriteNumbers[0]);
            Assert.Throws<ArgumentOutOfRangeException>(() => favoriteNumbers[99]);

            var firstTwo = (int)favoriteNumbers[0] + (int)favoriteNumbers[1];
            Assert.Equal(30, firstTwo);
        }

        [Fact]
        public void UsingAGenericList()
        {
            // List of int - generics provide parametric polymorphism
            var favoriteNumbers = new List<int>();
            favoriteNumbers.Add(9);
            favoriteNumbers.Add(10);

            var firstTwo = favoriteNumbers[0] + favoriteNumbers[1];
            Assert.Equal(19, firstTwo);
        }

        [Fact]
        public void InitializingAndEnumeratingAList()
        {
            var friends = new List<string>
            {
                "Sean",
                "Amy",
                "Jessika",
                "Tim"
            };

            Assert.Equal("Sean", friends[0]);

            var friendString = "";
            foreach(string friend in friends)
            {
                friendString += friend;
            }
            Assert.Equal("SeanAmyJessikaTim", friendString);
        }

        [Fact]
        public void UsingADictionary()
        {
            var friends = new Dictionary<char, string>();
            friends.Add('s', "Sean");
            friends.Add('d', "David");

            Assert.Equal("David", friends['d']);
        }

        [Fact]
        public void InitializingAndEnumeratingADictionary()
        {
            var friends = new Dictionary<char, string>
            {
                { 's', "Sean" },
                { 'd', "David" },
            };

            Assert.Equal("David", friends['d']);

            Assert.True(friends.ContainsKey('d'));
            Assert.False(friends.ContainsValue("Billy"));

            foreach(char c in friends.Keys)
            {
                // have the key here... 's', 'd'
            }

            foreach(string f in friends.Values)
            {
                // have the values here... "Sean", "David"
            }

            foreach(KeyValuePair<char, string> keyValuePair in friends)
            {

            }
        }

        [Fact]
        public void ArraysAreCoolButLimited()
        {
            string[] friends = new string[] { "Joe", "Bill", "Sue", "Mary" };
            Assert.Equal("Joe", friends[0]);

            var otherFriends = new string[3];
        }
    }
}
