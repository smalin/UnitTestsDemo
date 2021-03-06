﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using NUnit.Framework;

namespace UnitTestsDemo
{
    [TestFixture]
    public class AccountTests
    {
        Account account;

        public AccountTests()
        {
            // Uruchamia się przed wszystkimi przypadkami testowymi w tej klasie
        }

        [SetUp]
        public void SetUp()
        { 
            // Uruchamia się przed każdym testem
            // Inicjalizacja Ninjecta, Sesji itp.
            account = new Account();
        }

        [TearDown]
        public void TearDown()
        {
            // Uruchamia się po każdym teście
            // Dispose, zamykanie sesji itp.
           // account.Dispose();
        }


       [Test]
        public void Method_Scenario_Result()
        {
            // Arrange


            // Act


            // Assert

        }

        [Test]
        //[Ignore]
        //[Explicit]
        public void Deposit_PositiveValue_ShouldAddToBalance()
        {
            // Arrange
            account = new Account();

            // Act
            account.Deposit(100);

            // Assert
            Assert.AreEqual(100, account.Balance);
  
        }
      

        [Test]
        public void TransferFunds_WhenHaveFunds_ShouldTransfer()
        {
           // AAA

           // Arrange 
           var  src = new Account();
            src.Deposit(200);

            var dst = new Account();
            dst.Deposit(100);

            // Act
            src.TransferFunds(dst, 100);

            // Assert
            Assert.AreEqual(200, dst.Balance);
            Assert.AreEqual(100, src.Balance);
            
        }

        [Test]
        public void TransferFunds_WhenNoFunds_ShouldThrowsException()
        {
            Account source = new Account();
            source.Deposit(150m);

            Account destination = new Account();
            destination.Deposit(200m);

            //source.TransferFunds(destination, 200);

            Assert.Throws<Exception>(() =>  source.TransferFunds(destination, 200));

            Assert.AreEqual(150m, source.Balance);
            Assert.AreEqual(400m, destination.Balance);
        }

        [Test]
        public void TransferFunds_WhenTransfer1000_ShouldThrowsException()
        {
            Account source = new Account();
            source.Deposit(2000);
            Account destination = new Account();

            Assert.Throws<Exception>(() => source.TransferFunds(destination, 1500));
          
        }


        //public class TransferFunds : AccountTests
        //{
        //    [SetUp]
        //    public void SetUp()
        //    {
        //        // Uruchamia się przed każdym testem
        //        // Inicjalizacja Ninjecta, Sesji itp.
        //        account = new Account();
        //    }

        //    [Test]
        //    public void WhenHaveFunds_ShouldTransfer()
        //    {
        //        // Arrange 
        //        var src = new Account();
        //        src.Deposit(200);

        //        var dst = new Account();
        //        dst.Deposit(100);

        //        // Act
        //        src.TransferFunds(dst, 100);

        //        // Assert
        //        Assert.AreEqual(200, dst.Balance);
        //        Assert.AreEqual(100, src.Balance);

        //    }

        //    [Test]
        //    public void WhenNoFunds_ShouldThrowsException()
        //    {
        //        Account source = new Account();
        //        source.Deposit(150m);

        //        Account destination = new Account();
        //        destination.Deposit(200m);

        //        Assert.Throws<Exception>(() => source.TransferFunds(destination, 200));

        //        Assert.AreEqual(150m, source.Balance);
        //        Assert.AreEqual(400m, destination.Balance);
        //    }
        //}


        //public class Deposit : AccountTests
        //{
        //    [Test]
        //    public void PositiveValue_ShouldAddToBalance()
        //    {
        //        // Arrange
        //        account = new Account();

        //        // Act
        //        account.Deposit(100);

        //        // Assert
        //        Assert.AreEqual(100, account.Balance);
        //    }
        //}
    }
}
