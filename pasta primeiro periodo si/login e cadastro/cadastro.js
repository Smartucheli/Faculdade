


let btnVersenha = document.querySelector('#VerConfirmSenha');
let btnConfirmSenha = document.querySelector('#VerSenha');
let msgErro = document.querySelector('#msgErro');
let msgSucess = document.querySelector('#msgSucess');


let nome = document.querySelector('#nome');
let labelnome = document.querySelector('#label-nome');
let validNome = false;


let usuario = document.querySelector('#usuario');
let labelUsuario = document.querySelector('#label-usuario');
let validUsuario = false;


let senha = document.querySelector('#senha');
let labelSenha = document.querySelector('#label-senha');
let validSenha = false;


let ConfirmSenha = document.querySelector('#confirmSenha');
let labelConfirmSenha = document.querySelector('#label-confirmSenha');
let validConfirmSenha = false;

nome.addEventListener('keyup', () => {
    if(nome.value.length <= 2){
        labelnome.setAttribute('style', 'color: red');
        labelnome.innerHTML = 'Nome *Insira no minimo 3 caracteres'
        nome.setAttribute('style', 'border-color: red');
        validNome = false;
    } else {
        labelnome.setAttribute('style', 'color: green');
        labelnome.innerHTML = 'nome';
        nome.setAttribute('style', 'border-color: green');
        validNome = true;
    }
})


usuario.addEventListener('keyup', () => {
    if(usuario.value.length <= 4){
        labelUsuario.setAttribute('style', 'color: red');
        labelUsuario.innerHTML = 'Usuario *Insira no minimo 5 caracteres';
        usuario.setAttribute('style', 'border-color: red');
        validUsuario = false;
    } else {
        labelUsuario.setAttribute('style', 'color: green');
        labelUsuario.innerHTML = 'usuario';
        usuario.setAttribute('style', 'border-color: green');
        validUsuario = true;
    }
})


senha.addEventListener('keyup', () => {
    if(senha.value.length <= 5){
        labelSenha.setAttribute('style', 'color: red');
        labelSenha.innerHTML = 'Senha *Insira no minimo 6 caracteres';
        senha.setAttribute('style', 'border-color: red');
        validSenha = false;
    } else {
        labelSenha.setAttribute('style', 'color: green');
        labelSenha.innerHTML = 'senha';
        senha.setAttribute('style', 'border-color: green');
        validSenha = true;
    }
})

ConfirmSenha.addEventListener('keyup', () => {
    if(senha.value != ConfirmSenha.value){
        labelConfirmSenha.setAttribute('style', 'color: red');
        labelConfirmSenha.innerHTML = 'Confirmar Senha *Confirmação de senha inválida';
        ConfirmSenha.setAttribute('style', 'border-color: red');
        validConfirmSenha = false;
    } else {
        labelConfirmSenha.setAttribute('style', 'color: green');
        labelConfirmSenha.innerHTML = 'Confirmar senha';
        ConfirmSenha.setAttribute('style', 'border-color: green');
        validConfirmSenha = true;
    }
})

function cadastrar(){
    if(validNome && validUsuario && validSenha && validConfirmSenha){
        fetch(URL, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: "usuarios"
        })
        .then(res => res.json())
        .then(() => location.reload());  
        

        setTimeout(() => {
            window.location.href = 'http://127.0.0.1:5500/login.html'
        }, 3000);

        msgSucess.setAttribute('style', 'display: block');
        msgSucess.innerHTML = '<strong>Cadastrando Usuario...</strong>';
        msgErro.setAttribute('style', 'display: none');
        msgErro.innerHTML = '';
    } else {
        msgErro.setAttribute('style', 'display: block');
        msgErro.innerHTML = '<strong>Preencha todos os campos corretamente antes de cadastrar</strong>';
        msgSucess.setAttribute('style', 'display: none');
        msgSucess.innerHTML = '';
    }
}





btnVersenha.addEventListener('click', () => {
    let inputsenha = document.querySelector('#Confirmsenha');
    if(inputsenha.getAttribute('type') == 'password'){
        inputsenha.setAttribute('type', 'text');
    } else {
        inputsenha.setAttribute('type', 'password');
    }
})


btnConfirmSenha.addEventListener('click', () => {
    let inputsenha = document.querySelector('#senha');
    if(inputsenha.getAttribute('type') == 'password'){
        inputsenha.setAttribute('type', 'text');
    } else {
        inputsenha.setAttribute('type', 'password');
    }
})

