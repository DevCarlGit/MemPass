using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemPass
{
    public partial class Form1 : Form
    {
        private const string LowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UpperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NumericChars = "1234567890";
        private const string SpecialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>/?`~";
        private const string SpecialCharsMemorable = "!@#$%&*?";

        private bool isTraditionalMode = true;

        // String arrays for each category
        private string[] cuteWords = {
    "adorable",
    "sweet",
    "charming",
    "lovable",
    "delightful",
    "endearing",
    "enchanting",
    "precious",
    "darling",
    "captivating",
    "alluring",
    "appealing",
    "winsome",
    "pleasing",
    "attractive",
    "irresistible",
    "charismatic",
    "bewitching",
    "heartwarming",
    "cuddly",
    "snuggly",
    "angelic",
    "cherubic",
    "kawaii",
    "giggly",
    "zippy",
    "merry",
    "jovial",
    "radiant",
    "sunny",
    "blossom",
    "panda",
    "unicorn",
    "teddybear",
    "snugglebug",
    "fluffy",
    "cotton",
    "candy",
    "sugarplum",
    "peachy",
    "tender",
    "dreamy",
    "honeyed",
    "angelic",
    "loveable",
    "softy",
    "heart",
    "puppy",
    "tender"
};

        private string[] animalWords = {
    "lion",
    "tiger",
    "bear",
    "eagle",
    "giraffe",
    "monkey",
    "kangaroo",
    "panda",
    "dolphin",
    "cheetah",
    "leopard",
    "squirrel",
    "elephant",
    "hippo",
    "rhino",
    "fox",
    "shark",
    "sloth",
    "parrot",
    "parakeet",
    "sloth",
    "hyena",
    "crocodile",
    "frog",
    "platypus",
    "hedgehog",
    "rabbit",
    "lemur",
    "explorer",
    "panther",
    "otter",
    "wolf",
    "raccoon",
    "armadillo",
    "koala",
    "beaver",
    "meerkat",
    "dolphin",
    "gazelle",
    "chipmunk",
    "porcupine",
    "cobra",
    "bat",
    "ocelot",
    "adventurous",
    "sneaky",
    "graceful",
    "swift",
    "majestic",
    "wise",
    "mysterious",
    "fierce",
    "courageous",
    "gentle",
    "playful",
    "regal",
    "sly",
    "vibrant"
};

        private string[] sportsWords = {
    "soccer",
    "basketball",
    "football",
    "tennis",
    "golf",
    "swimming",
    "cycling",
    "running",
    "volleyball",
    "boxing",
    "hiking",
    "skiing",
    "surfing",
    "climbing",
    "gymnastics",
    "yoga",
    "karate",
    "rugby",
    "baseball",
    "softball",
    "hockey",
    "badminton",
    "marathon",
    "triathlon",
    "cricket",
    "fencing",
    "archery",
    "sprint",
    "judo",
    "diving",
    "paragliding",
    "skateboarding",
    "wrestling",
    "kickboxing",
    "boxing",
    "sailing",
    "rowing",
    "snowboarding",
    "wakeboarding",
    "biking",
    "jogging",
    "walking",
    "climbing",
    "shooting"
};

        private bool isMemorableMode = false;

        // Modify the form initialization to set the initial mode
        public Form1()
        {
            InitializeComponent();
            InitializeTraditionalMode();
            SetModeButtonLabel();

            cutePasswordButton.Click += (sender, e) => GenerateMemorablePassword(cuteWords);
            animalPasswordButton.Click += (sender, e) => GenerateMemorablePassword(animalWords);
            sportsPasswordButton.Click += (sender, e) => GenerateMemorablePassword(sportsWords);
        }

        // Replace memorableModeButton_Click and traditionalModeButton_Click with the following method
        private void modeToggleButton_Click(object sender, EventArgs e)
        {
            isMemorableMode = !isMemorableMode;

            if (isMemorableMode)
                InitializeMemorableMode();
            else
                InitializeTraditionalMode();

            SetModeButtonLabel();
        }

        // Add this method to update the label of the mode toggle button
        private void SetModeButtonLabel()
        {
            modeToggleButton.Text = isMemorableMode ? "Memorable Mode" : "Traditional Mode";
        }

        private void InitializeTraditionalMode()
        {
            lengthTextBox.Text = "10";
            passwordLabel.Text = "Password Length";

            lowerCheckBox.Checked = true;
            upperCheckBox.Checked = true;
            lowerCheckBox.Enabled = true;
            upperCheckBox.Enabled = true;

            generatePasswordButton.Enabled = true;

            cutePasswordButton.Visible = false;
            animalPasswordButton.Visible = false;
            sportsPasswordButton.Visible = false;
        }

        private void InitializeMemorableMode()
        {
            lengthTextBox.Text = "3";
            passwordLabel.Text = "Word Length";

            lowerCheckBox.Checked = true;
            upperCheckBox.Checked = true;
            lowerCheckBox.Enabled = false;
            upperCheckBox.Enabled = false;

            generatePasswordButton.Enabled = false;

            cutePasswordButton.Visible = true;
            animalPasswordButton.Visible = true;
            sportsPasswordButton.Visible = true;
        }

        private void SetMode(bool isTraditional)
        {
            isTraditionalMode = isTraditional;

            if (isTraditional)
            {
                InitializeTraditionalMode();
                generatePasswordButton.Enabled = true;

                cutePasswordButton.Visible = false;
                animalPasswordButton.Visible = false;
                sportsPasswordButton.Visible = false;
            }
            else
            {
                InitializeMemorableMode();
                generatePasswordButton.Enabled = false;

                cutePasswordButton.Visible = true;
                animalPasswordButton.Visible = true;
                sportsPasswordButton.Visible = true;
            }
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            if (isTraditionalMode)
                GenerateTraditionalPassword();
        }

        private void GenerateTraditionalPassword()
        {
            if (!int.TryParse(lengthTextBox.Text, out int length) || length <= 0)
            {
                ShowError("Invalid password length. Please enter a valid positive number.");
                return;
            }

            bool includeLower = lowerCheckBox.Checked;
            bool includeUpper = upperCheckBox.Checked;
            bool includeNumeric = numericCheckBox.Checked;
            bool includeSpecial = specialCheckBox.Checked;

            string password = GeneratePassword(includeLower, includeUpper, includeNumeric, includeSpecial, length);
            resultTextBox.Text = password;
        }

        private string GeneratePassword(bool includeLower, bool includeUpper, bool includeNumeric, bool includeSpecial, int length)
        {
            if (!includeLower && !includeUpper && !includeNumeric && !includeSpecial)
            {
                ShowError("Please check at least one option.");
                return string.Empty;
            }

            StringBuilder charSetBuilder = new StringBuilder();
            Random random = new Random();

            if (includeLower)
                charSetBuilder.Append(LowerCaseChars);
            if (includeUpper)
                charSetBuilder.Append(UpperCaseChars);
            if (includeNumeric)
                charSetBuilder.Append(NumericChars);
            if (includeSpecial)
                charSetBuilder.Append(SpecialChars);

            string charSet = charSetBuilder.ToString();

            char[] password = new char[length];
            for (int i = 0; i < length; i++)
                password[i] = charSet[random.Next(charSet.Length)];

            return new string(password);
        }

        private void GenerateMemorablePassword(string[] words)
        {
            if (!int.TryParse(lengthTextBox.Text, out int wordLength) || wordLength <= 0)
            {
                ShowError("Invalid word length. Please enter a valid positive number.");
                return;
            }

            GenerateMemorablePassword(words, wordLength);
        }

        private void GenerateMemorablePassword(string[] words, int wordLength)
        {
            if (words.Length == 0)
            {
                ShowError("No words found in the array.");
                resultTextBox.Text = string.Empty;
                return;
            }

            if (wordLength > words.Length)
            {
                ShowError("Not enough words in the array to generate the requested password length.");
                resultTextBox.Text = string.Empty;
                return;
            }

            Random random = new Random();
            HashSet<string> selectedWords = new HashSet<string>();

            while (selectedWords.Count < wordLength)
            {
                string randomWord = UppercaseFirstLetter(words[random.Next(words.Length)]);
                selectedWords.Add(randomWord);
            }

            // Check if numeric checkbox is checked, add a random number to the end
            if (numericCheckBox.Checked)
            {
                int randomNumber = random.Next(10); // Generate a random number between 0 and 9
                selectedWords.Add(randomNumber.ToString());
            }

            // Check if special character checkbox is checked, add a random special character to the end
            if (specialCheckBox.Checked)
            {
                char randomSpecialChar = SpecialCharsMemorable[random.Next(SpecialCharsMemorable.Length)];
                selectedWords.Add(randomSpecialChar.ToString());
            }

            resultTextBox.Text = string.Join("", selectedWords);
        }

        private string UppercaseFirstLetter(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            char[] charArray = word.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        private void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultTextBox.Text))
            {
                Clipboard.SetText(resultTextBox.Text);
                MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
