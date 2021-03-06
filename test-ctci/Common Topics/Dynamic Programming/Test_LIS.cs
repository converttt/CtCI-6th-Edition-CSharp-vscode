using System;
using Xunit;
using Common_Topics;

namespace test_ctci
{
    public class Test_LIS
    {
        [Fact]
        public void TestLIS()
        {
            Assert.Equal(6, LIS.FindMax(new int[] {
                10, 22, 9, 33, 21, 50, 41, 60, 80
            }));

            Assert.Equal(3, LIS.FindMax(new int[] {
                3, 10, 2, 1, 20
            }));
        }

        [Fact]
        public void TestMaxOfChains()
        {
            Assert.Equal(3, LIS.FindMaxOfChains(new Tuple<int, int>[] {
                new Tuple<int, int>(5, 24),
                new Tuple<int, int>(39, 60),
                new Tuple<int, int>(15, 28),
                new Tuple<int, int>(27, 40),
                new Tuple<int, int>(50, 90),
            }));
        }

        [Fact]
        public void TestMaxOfStrings()
        {
            Assert.Equal(3, LIS.FindMaxOfStrings("qweeer", "reeewq"));
            Assert.Equal(5, LIS.FindMaxOfStrings("hello world", "who lo wolf"));
        }

        [Fact]
        public void TestFindNumInsertions()
        {
            Assert.Equal(1, LIS.FindNumInsertions("ab"));
            Assert.Equal(0, LIS.FindNumInsertions("aa"));
            Assert.Equal(3, LIS.FindNumInsertions("abcd"));
            Assert.Equal(4, LIS.FindNumInsertions("abcda"));
            Assert.Equal(4, LIS.FindNumInsertions("abcde"));
        }
    }
}