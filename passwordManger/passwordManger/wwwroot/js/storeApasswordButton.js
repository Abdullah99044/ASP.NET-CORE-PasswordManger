//A fucntion that Open and close the form of the store-password-btn


const storePasswordButton = document.getElementById("store-password-btn");
const myForm = document.getElementById("createPasswordForm");

storePasswordButton.addEventListener('click', function () {
    myForm.classList.toggle('hidden-form');
    myForm.classList.toggle('form-show');
    console.log("Form visibility toggled");
});