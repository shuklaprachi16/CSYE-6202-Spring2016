using System;
using ConsoleApplication1;
using NUnit.Framework;

namespace ConsoleApplication1.Tests
{
    [TestFixture]

    public class whenRunningApplication
    {
        #region calculateSalary Tests

        [Test]
        public void When_CalculateSalary_SalariedEmployee_ResultShouldBeEqualToWeeklyWage()
        {

            var expected = 100;
            SalariedEmployee s = new SalariedEmployee("prachi", 123456789);
           var actual =  s.calculateEarned(100);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_CalculateSalary_HourlyEmployee_ResultShouldBeHourlyWageTimesHoursWorked() {
            HourlyEmployee h = new HourlyEmployee("prachi", 123456789);
            var expected = 1375;
            var actual = h.CalculatEarned(50, 25);
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_CalculateSalary_CommissionSale_ResultShouldBe_GrossSaleTimesRate() {
            CommissionEmployee c = new CommissionEmployee("prachi", 123456789);
            var expected = 4.0;
            var actual = c.CalculateEarned(20, (float)0.2);
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_CalculateSalary_BaseCommissionEmployee_ResultShouldBe_BasePlusGrossTimesRate() {
            SalaryBasedCommissionEmployee s = new SalaryBasedCommissionEmployee("prachi", 123456789);
            var expected = 4.0;
            var actual = s.CalculateEarned((float)2.0, 10, (float)0.2);
            Assert.That(expected, Is.EqualTo(actual));
            
        }

        #endregion

        #region ValidateEmptyName Tests
        [Test]
        public void When_UserNameIsEmpty_SalariedEmployee() {
           
            var e = true;
            var a = SalariedEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserNameIsEmpty_HourlyEmployee()
        {

            var e = true;
            var a = HourlyEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserNameIsEmpty_SaleCommssionEmployee()
        {

            var e = true;
            var a = CommissionEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserNameIsEmpty_BaseSaleCommsionEmployee()
        {

            var e = true;
            var a = SalaryBasedCommissionEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }
        #endregion

        #region ValidateSSN Tests
        [Test]
        public void When_UserEnteredSSN_IsNotValid_SalariedEmployee() {
            var e = true;
            var a = SalariedEmployee.UserEnteredInvalidSSN(1212);
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserEnteredSSN_IsNotValid_HourlyEmployee()
        {
            var e = true;
            var a = HourlyEmployee.UserEnteredInvalidSSN(1212);
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserEnteredSSN_IsNotValid_CommissionSales()
        {
            var e = true;
            var a = CommissionEmployee.UserEnteredInvalidSSN(1212);
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserEnteredSSN_IsNotValid_SalaryBasedCommission()
        {
            var e = true;
            var a = SalaryBasedCommissionEmployee.UserEnteredInvalidSSN(1212);
            Assert.That(e, Is.EqualTo(a));
        }
        #endregion
    }

}



