using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using Password_Generator;

namespace MyTestClass
{
    [TestClass]
    public class UnitTest1
    {

        
        public void TestPictureBox3Click1()
        {
            // Arrange
            Form1 form = new Form1();
            form.label_length_of_password.Text = "6";

            // Act
            form.pictureBox3_Click_1(null, null);
            int newLength = int.Parse(form.label_length_of_password.Text);

            // Assert
            Assert.IsTrue(newLength >= 8 && newLength <= 16, "The password length should be between 8 and 16");
        }
    }
}
