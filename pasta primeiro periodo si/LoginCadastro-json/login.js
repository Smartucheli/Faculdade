const URL = "https://api-db-clubes-jesus.herokuapp.com/usuarios";

const btn = document.getElementById('fa-eye');
const user = document.getElementById('usuario');
const userLabel = document.getElementById('userLabel');    
const senhaUser = document.getElementById('senha');
const senhaLabel = document.getElementById('senhaLabel');
    
const msgErro = document.getElementById('msgErro')

function entrar(){
    
   fetch(URL).then(res => res.json()).then(dados => {
      const Listauser = dados;
      Listauser.forEach(i => {

        const { usuario, senha } = i;
        if(usuario == user.value && senha == senhaUser.value){
          window.location.href = 'https://pucminas.instructure.com/?login_success=1';
      } else {  
        msgErro.setAttribute('style', 'display: block');
        msgErro.innerHTML = 'Usuario ou senha incorretos';
      }
      });
   })
     
  
}






