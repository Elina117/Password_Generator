using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection.Emit;
using Password_Generator;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MyTestClass
{
    [TestClass]
    public class UnitTest1
    {
        public Form1 form;


      

        [TestMethod]
        public void GeneratePassword_WhenCheckBox123Checked()
        {
            // Arrange
            form.checkBox_123.Checked = true;
            form.checkBox_high_ABC.Checked = false;
            form.checkBox_abc.Checked = false;
            form.checkBox_symbols.Checked = false;
            form.label_length_of_password.Text = "8";

            // Act
            form.button_generate_Click(null, null);

            // Assert
            Assert.AreEqual(8, form.textBox_password.Text.Length);
            Assert.IsTrue(ContainsOnlyDigits(form.textBox_password.Text));
        }

        [TestMethod]
        public void GeneratePassword_WhenCheckBoxHighABCChecked()
        {
            // Arrange
            form.checkBox_123.Checked = false;
            form.checkBox_high_ABC.Checked = true;
            form.checkBox_abc.Checked = false;
            form.checkBox_symbols.Checked = false;
            form.label_length_of_password.Text = "10";

            // Act
            form.button_generate_Click(null, null);

            // Assert
            Assert.AreEqual(10, form.textBox_password.Text.Length);
            Assert.IsTrue(ContainsOnlyUppercaseLetters(form.textBox_password.Text));
        }

        [TestMethod]
        public void GeneratePassword_WhenCheckBoxABCAndSymbolsChecked()
        {
            // Arrange
            form.checkBox_123.Checked = false;
            form.checkBox_high_ABC.Checked = false;
            form.checkBox_abc.Checked = true;
            form.checkBox_symbols.Checked = true;
            form.label_length_of_password.Text = "12";

            // Act
            form.button_generate_Click(null, null);

            // Assert
            Assert.AreEqual(12, form.textBox_password.Text.Length);
            Assert.IsTrue(ContainsOnlyLettersAndSymbols(form.textBox_password.Text));
        }

        [TestMethod]
        public void GeneratePassword_WhenAllOptionsChecked()
        {
            // Arrange
            form.checkBox_123.Checked = true;
            form.checkBox_high_ABC.Checked = true;
            form.checkBox_abc.Checked = true;
            form.checkBox_symbols.Checked = true;
            form.label_length_of_password.Text = "16";

            // Act
            form.button_generate_Click(null, null);

            // Assert
            Assert.AreEqual(16, form.textBox_password.Text.Length);
            Assert.IsTrue(ContainsMixedCharacters(form.textBox_password.Text));
        }

        [TestMethod]
        public void GeneratePassword_WhenNoOptionsChecked()
        {
            // Arrange
            form.checkBox_123.Checked = false;
            form.checkBox_high_ABC.Checked = false;
            form.checkBox_abc.Checked = false;
            form.checkBox_symbols.Checked = false;
            form.label_length_of_password.Text = "6";

            // Act
            form.button_generate_Click(null, null);

            // Assert
            Assert.AreEqual(0, form.textBox_password.Text.Length);
        }

        private bool ContainsOnlyDigits(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool ContainsOnlyUppercaseLetters(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsUpper(c))
                    return false;
            }
            return true;
        }

        private bool ContainsOnlyLettersAndSymbols(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && !char.IsSymbol(c))
                    return false;
            }
            return true;
        }

        private bool ContainsMixedCharacters(string text)
        {
            bool hasDigit = false;
            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasSymbol = false;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    hasDigit = true;
                else if (char.IsUpper(c))
                    hasUppercase = true;
                else if (char.IsLower(c))
                    hasLowercase = true;
                else if (char.IsSymbol(c) || char.IsPunctuation(c))
                    hasSymbol = true;
            }

            return hasDigit && hasUppercase && hasLowercase && hasSymbol;
        }

        [TestMethod]
        public void Click_WhenCurrentLengthLessThan16_IncreasesLengthBy2()
        {
            form.label_length_of_password.Text = "10";

            // Act
            form.pictureBox3_Click_1(null, null);

            // Assert
            Assert.AreEqual("12", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_WhenCurrentLengthIs16_DoesNotIncreaseLength()
        {
           
            form.label_length_of_password.Text = "16";

            // Act
            form.pictureBox3_Click_1(null, null);

            // Assert
            Assert.AreEqual("16", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_WhenCurrentLengthGreaterThan16_DoesNotIncreaseLength()
        {
    
            form.label_length_of_password.Text = "20";

            // Act
            form.pictureBox3_Click_1(null, null);

            // Assert
            Assert.AreEqual("16", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_UpdatesLengthLabel()
        {
      
            form.label_length_of_password.Text = "8";

            // Act
            form.pictureBox3_Click_1(null, null);

            // Assert
            Assert.AreEqual("10", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_WithInvalidLengthLabelValue_SetsLengthToDefault()
        {
            // Arrange
           
            form.label_length_of_password.Text = "abc";

            // Act
            form.pictureBox3_Click_1(null, null);

            // Assert
            Assert.AreEqual("2", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_WhenCurrentLengthGreaterThan2_DecreasesLengthBy2()
        {
          
            form.label_length_of_password.Text = "8";

            // Act
            form.pictureBox2_Click(null, null);

            // Assert
            Assert.AreEqual("6", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_WhenCurrentLengthIs2_DoesNotDecreaseLength()
        {
         
            form.label_length_of_password.Text = "2";

            // Act
            form.pictureBox2_Click(null, null);

            // Assert
            Assert.AreEqual("2", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_WhenCurrentLengthIs0_DoesNotDecreaseLength()
        {
   
            form.label_length_of_password.Text = "0";

            // Act
            form.pictureBox2_Click(null, null);

            // Assert
            Assert.AreEqual("0", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_UpdatesLength()
        {
       
            form.label_length_of_password.Text = "8";

            // Act
            form.pictureBox2_Click(null, null);

            // Assert
            Assert.AreEqual("6", form.label_length_of_password.Text);
        }

        [TestMethod]
        public void Click_WithInvalidLengthLabelValue_ToDefault()
        {
           
            form.label_length_of_password.Text = "abc";

            // Act
            form.pictureBox2_Click(null, null);

            // Assert
            Assert.AreEqual("0", form.label_length_of_password.Text);
        }






    }
}
