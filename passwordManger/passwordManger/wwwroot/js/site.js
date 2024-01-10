


//Check the strength of user password

const PassWord = document.getElementById("PassWord");
const PasswordStrength = document.getElementById("PasswordStrengthValidation");
 
PassWord.addEventListener("input", function(event) {
    const value = event.target.inputElement;

    PasswordStrength.style.color = "red";

 
    if(value === ""){
        PasswordStrength.value = "";
    }

    const strength = checkPasswordStrength(PassWord.value);

    PasswordStrength.textContent = "Weak";
    
    if (strength < 3) {

        PasswordStrength.textContent = "Weak password.";
        console.log("weak")

    } else if (strength < 5) {
        console.log("Moderate")

        PasswordStrength.textContent = "Moderate password.";
        PasswordStrength.style.color = "yellow";

    } else {
        console.log("Strong")

        PasswordStrength.textContent = "Strong password.";
        PasswordStrength.style.color = "green";


    }
});


function checkPasswordStrength(password){

     

    let strength = 0;

    if(password.length > 8){

        strength++;
    }

    if(/[A-Z]/.test(password)){
        strength++;
    }

    if (/[a-z]/.test(password)) {
        strength++;
    }

    if(/[0-9]/.test(password)){
        strength++
    }

    if (/[!@#$%^&*(),.?":{}|<>]/.test(password)) {
        strength++;
    }

    return strength;
}


//Validate an Input and send error massage

const validateInput = (value, spanName, inputName) => {

    const validationMessage = document.getElementById(spanName);

    if (value === "") {
        validationMessage.textContent = `${inputName} is Required`;
        return false;
    }

    validationMessage.textContent = ""; //Clear the error massage
    return true;
};

//Validate the form
function validateForm(event) {
    event.preventDefault();
    const form = document.getElementById("createPasswordForm");


    //All infor of your form inputs

    const inputs = [
        { id: "Name", spanId: "NameValidation", name: "Name" },
        { id: "URL", spanId: "URLValidation", name: "URL" },
        { id: "PassWord", spanId: "PassWordValidation", name: "Password" },
        
    ];

    //Validate every input
    const isValid = inputs.every(input => {
        const inputElement = document.getElementById(input.id);
        const inputValue = inputElement.value.trim();
        return validateInput(inputValue, input.spanId, input.name);
    });

    if (isValid) {

        if(PasswordStrength.textContent == "Strong password."){

            form.submit();

        }
  
    }
}

//Generate a password


const passwordGeneratorButton = document.getElementById("passwordGenerator");
 

passwordGeneratorButton.addEventListener('click' , function(){

    const generatedPassword = passwordGenerator();
    
    PassWord.value = generatedPassword;

    //Invoke the event inside password input
    PassWord.dispatchEvent(new Event('input'))

});

function passwordGenerator(){

    let newPassword = '';

    
    const upperCaseChars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    const lowwerCaseChars = 'abcdefghijklmnopqrstuvwxyz';
    const digitChars = '0123456789';
    const specialChars = '!@#$%^&*()';


    newPassword +=  getRandomChar(upperCaseChars);
    newPassword +=  getRandomChar(lowwerCaseChars);
    newPassword +=  getRandomChar(digitChars);
    newPassword +=  getRandomChar(specialChars);


    //Add 4 randomize chars to the password
    for(let i = 0 ; i != 5 ; i++){
       
        const charset = upperCaseChars + lowwerCaseChars + digitChars + specialChars;
        newPassword += getRandomChar(charset);
       
    }

    //Shffle the password
    newPassword = shuffleString(newPassword);


    

    return newPassword;
}


function getRandomChar(charSet) {

    const randomIndex = Math.floor(Math.random() * charSet.length);
    return charSet[randomIndex];
}

//Shffle function

function shuffleString(string) {
    const charArray = string.split('');
    for (let i = charArray.length - 1; i > 0; i--) {
      const j = Math.floor(Math.random() * (i + 1));
      [charArray[i], charArray[j]] = [charArray[j], charArray[i]];
    }
    return charArray.join('');
}



