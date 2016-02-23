using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialsProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        protected InitialsRunner Instance = new InitialsRunner();

        [TestMethod]
        public void make_sure_name_with_dash_is_na()
        {
            string name = "John Joseph-staliniemer";
            string shouldBe = "NA";
            var result = Instance.GetInitials(name.ToCharArray());
            Assert.AreEqual(result, shouldBe);
        }

        [TestMethod]
        public void make_sure_that_name_gives_us_correct_initials()
        {
            string name = "Mabae Funke";
            string shouldBe = "MF";

            var result = Instance.GetInitials(name.ToCharArray());
            Assert.AreEqual(result, shouldBe);

        }

        [TestMethod]
        public void make_sure_that_name_with_extra_spaces_is_correct()
        {
            string name = "George Michael ";
            string shouldBe = "GM";

            var result = Instance.GetInitials(name.ToCharArray());
            Assert.AreEqual(result, shouldBe);
        }

        [TestMethod]
        public void make_sure_that_you_also_look_at_casing_issues()
        {
            string name = "gEorGe oScaR Bluth";
            string shouldBe = "GOB";

            var result = Instance.GetInitials(name.ToCharArray());
            Assert.AreEqual(result, shouldBe);
        }

        [TestMethod]
        public void make_sure_that_you_take_special_cases_for_transpose_errors()
        {
            string name = "Oscar  Bluth";
            string shoudlBe = "OB";

            var result = Instance.GetInitials(name.ToCharArray());
            Assert.AreEqual(result, shoudlBe);
        }

    }
}
