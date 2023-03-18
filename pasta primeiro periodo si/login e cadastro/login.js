let btn = document.querySelector('.fa-eye');


function entrar(){
    let usuario = document.querySelector('#usuario');
    let userLabel = document.querySelector('#userLabel');
    
    let senha = document.querySelector('#senha');
    let senhaLabel = document.querySelector('#senhaLabel');
    
    let msgError = document.querySelector('#msgErro');
    let listaUser = [];
    
    let userValid = {
      nome: '',
      user: '',
      senha: ''
    }
    
    fetch(URL, {
      method: 'GET',
      headers: {
          'Content-Type': 'application/json'
      },
      body: "usuarios"
  })
  .then(res => res.json())
  .then(() => location.reload());  
    
    listaUser.forEach((item) => {
      if(usuario.value == item.userCad && senha.value == item.senhaCad){
         
        userValid = {
           nome: item.nomeCad,
           user: item.userCad,
           senha: item.senhaCad
         }
        
      }
    })
     
    if(usuario.value == userValid.user && senha.value == userValid.senha){
        window.location.href = 'https://www.youtube.com/watch?v=rQzSiiRe6YM';
    
        let mathRandom = Math.random().toString(16).substr(2);
        let token = mathRandom + mathRandom;
        
        localStorage.setItem('token', token);
        localStorage.setItem('userLogado', JSON.stringify(userValid));
    } else {  
      msgError.setAttribute('style', 'display: block');
      msgError.innerHTML = 'Usuario ou senha incorretos';
      usuario.focus();
    }
}




btn.addEventListener('click', () => {
    let inputsenha = document.querySelector('#senha');
    if(inputsenha.getAttribute('type') == 'password'){
        inputsenha.setAttribute('type', 'text');
    } else {
        inputsenha.setAttribute('type', 'password');
    }
})


