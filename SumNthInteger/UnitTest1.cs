﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumNthInteger
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void N_larger_than_numbers_length_And_N_larger_than_0_sum_smaller_than_maxval()
        {
            var numbers = new[] { 4 };
            var n = 3;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "4");
        }

        [TestMethod]
        public void N_larger_than_numbers_length_And_N_larger_than_0_sum_larger_than_maxval()
        {
            var numbers = new[] { 40 };
            var n = 3;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "input invalid");
        }

        [TestMethod]
        public void N_larger_than_numbers_length_And_N_larger_than_0_sum_equal_to_maxval()
        {
            var numbers = new[] { 20 };
            var n = 3;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "input invalid");
        }

        [TestMethod]
        public void N_smaller_than_numbers_length()
        {
            var numbers = new[] { 4, 7, 5 };
            var n = 2;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "11");
        }

        [TestMethod]
        public void N_is_0()
        {
            var numbers = new[] { 4, 7, 5 };
            var n = 0;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "0");
        }

        [TestMethod]
        public void N_smaller_than_0()
        {
            var numbers = new[] { 4, 7, 5 };
            var n = -2;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "11");
        }

        [TestMethod]
        public void numbers_exist_negative_number()
        {
            var numbers = new[] { 4, -7, 5 };
            var n = 2;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "-3");
        }

        [TestMethod]
        public void sum_and_maxval_both_negative()
        {
            var numbers = new[] { 4, -7, 5 };
            var n = 2;
            var maxVal = -20;
            ResultShouldBe(numbers, n, maxVal, "input invalid");
        }

        [TestMethod]
        public void sum_and_maxval_both_negative_and_sum_smaller_than_maxval()
        {
            var numbers = new[] { 4, -7, 5 };
            var n = 2;
            var maxVal = -2;
            ResultShouldBe(numbers, n, maxVal, "-3");
        }

        [TestMethod]
        public void numbers_is_empty()
        {
            var numbers = new int[] { };
            var n = 2;
            var maxVal = 20;
            ResultShouldBe(numbers, n, maxVal, "0");
        }

        [TestMethod]
        public void numbers_is_empty_and_maxval_is_negative()
        {
            var numbers = new int[] { };
            var n = 2;
            var maxVal = -3;
            ResultShouldBe(numbers, n, maxVal, "input invalid");
        }

        private static void ResultShouldBe(int[] numbers, int n, int maxVal, string expected)
        {
            Assert.AreEqual(expected, new Kata(numbers).SumNthInteger(n, maxVal));
        }
    }
}