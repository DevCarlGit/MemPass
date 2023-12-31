# Memorable Password Generator
#### Video Demo: https://youtu.be/gcRv55fBfPE
#### Description
The Memorable Password Generator is a user-friendly application designed to empower individuals in creating robust and unforgettable passwords effortlessly. Offering a dual functionality, it caters to the need for both traditional random-character passwords and imaginative word-based passwords.

#### What Issue Does It Solve?
In an era where strong passwords are crucial, the Memorable Password Generator addresses the challenge of creating passwords that are not only robust but also easy to remember. Unlike auto-generated passwords that lack memorability, this tool allows users to craft passwords consisting of multiple words, adding a layer of security while ensuring ease of recall.

#### How Does It Work?
The application offers two modes:

1. **Traditional Mode:**
   - Users can generate random-character passwords by selecting options such as lowercase, uppercase, numerics, and special characters.
   - Adjustable password size provides flexibility.
   - The generated password can be copied to the clipboard for immediate use.

2. **Memorable Mode:**
   - Users can choose from three themes: cute, animal-related, and sports-related.
   - The application strings together words from predefined lists, allowing users to create memorable and secure passwords.
   - Optional inclusion of a random number and/or special character enhances password complexity.

#### Code Summary
The application is built in C# using Windows Forms. Key components include:

- **User Interface:**
  - Provides a clean and intuitive interface with options for password generation.
  - Dynamically adjusts based on the selected mode (traditional or memorable).

- **Password Generation:**
  - Traditional Mode generates random-character passwords based on user preferences.
  - Memorable Mode constructs passwords using predefined word lists, with optional numeric and special character additions.

- **Word Lists:**
  - Curated lists for cute, animal-related, and sports-related words enhance the memorability of passwords.

- **Error Handling:**
  - Ensures user input is valid, providing informative error messages when necessary.

- **Clipboard Interaction:**
  - Enables users to easily copy generated passwords to the clipboard for quick usage.

#### Future Improvements
I would like to expand on the application to offer a wider variety of categories to choose from, and including modes for generating "SVO" type passwords (subject-verb-object). For instance: "BrownHorseDoingSickKarate" or "CutePandaEatingTastyCherries". The interface is also very basic still, as it's my first time working with the Windows Forms, and I'd like to implement a user interface that's more scalable and generally tidier and less "default".
