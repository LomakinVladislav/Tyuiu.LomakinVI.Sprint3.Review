﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint3.TaskReview.V6.Lib;

namespace Tyuiu.LomakinVI.Sprint3.TaskReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray = new double[len];

            valueWaitArray[0] = 23.92;
            valueWaitArray[1] = 18.88;
            valueWaitArray[2] = 13.1;
            valueWaitArray[3] = 7.24;
            valueWaitArray[4] = 1.8;
            valueWaitArray[5] = -8;
            valueWaitArray[6] = -5.7;
            valueWaitArray[7] = -11.26;
            valueWaitArray[8] = -17.12;
            valueWaitArray[9] = -22.88;
            valueWaitArray[10] = -27.92;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, result);
        }
    }
}
