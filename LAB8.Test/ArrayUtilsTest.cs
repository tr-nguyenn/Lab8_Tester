using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8.Test
{
    [TestClass]
    public class ArrayUtilsTest
    {
        [TestMethod]
        public void FindMax_ValiAraay_ReturnsMax()
        {
            int[] array = { 3, 7, 1, 9, 4 };
            int expectedMax = 9;
            int actualMax = ArrayUtils.FindMax(array);

            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        public void FindMin_ValiAraay_ReturnsMin()
        {
            int[] array = { 3, 7, 1, 9, 4 };
            int expectedMin = 1;

            int actualMin = ArrayUtils.FindMin(array);
            Assert.AreEqual(expectedMin, actualMin);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMax_EmptyAraay_ThrowsException()
        {
            int[] array = { };
            ArrayUtils.FindMax(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMin_EmptyAraay_ThrowsException()
        {
            int[] array = { };
            ArrayUtils.FindMin(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMax_NullAraay_ThrowsException()
        {
            int[] array = null;
            ArrayUtils.FindMax(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMin_NullAraay_ThrowsException()
        {
            int[] array = null;
            ArrayUtils.FindMin(array);
        }

    }
}
