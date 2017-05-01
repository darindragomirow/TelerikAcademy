using Academy.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.CourseTests
{
    [TestFixture]
    public class SetName_Should
    {
        [TestCase("Pesho")]
        [TestCase("very very very very very very very very very very very very very very very very long string")]

        public void ThrowArgumentException_WhenInvalidValueIsPassed(string value)
        {
            var course = new Course("Valid name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            Assert.Throws<ArgumentException>(() => course.Name = value);
        }
        [Test]
        public void CorrectlyAssignPassedValue_WhenSetMethodIsCalled()
        {
            var course = new Course("Valid name", 5, new DateTime(2017, 02, 10), new DateTime(2017, 03, 10));

            var newName = "Pesho";
            course.Name = newName;

            Assert.AreEqual(newName, course.Name);
        }
    }
}
