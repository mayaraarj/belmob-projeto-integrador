<script setup>

</script>

<template>
<body>
  <main class="flex-container">
    <article>
      <h1>Como funciona?</h1>
      <div class="cliente">
        <img src="../assets/imagens/ParaClientes.png" alt="Acesse nosso site e escolha um dos nossos serviços. Realize o seu cadastro, escolhendo a melhor data e horário para você. Receba uma das nossas profissionais em casa ou no trabalho.">
      </div>
        
      <div class="funcionario">
        <img src="../assets/imagens/ParaFuncionarios.png" alt="Acesse nosso site e agende seu teste para trabalhar conosco. Seja uma profissional BelMob, pegue pedidos e monte sua própria agenda. Receba uma porcentagem maior que no salão, aumentando a sua renda conosco.">
      </div>
    </article>

<article>
  <h1>Serviços</h1>

  <div class="grid-container">

  <div class="servicoMao">
    <img src="../assets/imagens/maos.jpg" alt="Imagem de mãos com as unhas feitas">
    <div class="textoMao">
      <p>Mãos</p>
    </div>
  </div>

  <div class="servicoPe">
    <img src="../assets/imagens/pes.jpg" alt="Imagem de mãos com as unhas feitas">
    <p>Pés</p>
  </div>

  <div class="servicoMaosPes">
    <img src="../assets/imagens/maosPes.jpg" alt="Imagem de mãos e pés com as unhas feitas">
    <p>Mãos e pés</p>
  </div>

</div>
</article>

<article>
  <h1>Contate-nos</h1>
  <form>
    <label for="nome">Nome</label>
    <input type="text" id="nome" class="input-padrao" required placeholder="Nome completo">

    <label for="email">Email</label>
    <input type="email" id="email" class="input-padrao" required placeholder="email@dominio.com">

    <label for="telefone">Telefone</label>
    <input type="tel" id="telefone" class="input-padrao" required placeholder="(XX) XXXXX-XXXX">

    <label for="mensagem">Mensagem</label>
    <textarea cols="70" rows="10" id="mensagem" class="input-padrao" required placeholder="Escreva aqui sua mensagem"></textarea>
    
    <input type="submit" value="Enviar formulário">
  </form>
</article>         
</main>
</body>
</template>

<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
    background-image:url(../assets/imagens/unhas.jpg);
    background-position:center;
    background-repeat: no-repeat;
    background-size:cover;
    min-height: 100vh;
}

h1{
  font-family: 'Jacques Francois','Times New Roman', Times, serif;
  font-size: 60px;
  color: #562551;
  text-align: center;
  padding: 30px;
}

.flex-container {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
 
}

.cliente{
  opacity: 0.7;
  width: 80%;
}

.funcionario {
  opacity: 0.7;
  width: 80%;
}

.grid-container{
  display: grid;
  grid-template-columns: auto auto auto;
  justify-content:space-evenly;
  column-gap: 50px;
  padding: 20px 20px 20px 20px;
}

.servicoMao{
  width: 30%;
}

.servicoPe{
  width: 30%;
}

.servicoMaosPes{
  width: 30%;
}


p{
  font-family: 'Jacques Francois','Times New Roman', Times, serif;
  font-size: 25px;
  color: #562551;
  align-self: center;
}

form {
	margin: 30px 0;
  background: rgba(241, 241, 241, 0.43);
  width: 90%;
  margin-left: 50px;
  border: 2px solid rgba(86, 37, 81, 0.53);
  font-family: 'Jacques Francois';
    font-style: normal;
    font-size: 15px;
    color: #855a80;
  padding: 5%;
}

form label, form legend {
	display:block;
	font-size: 20px;
	margin: 0 0 10px;
  
}

.input-padrao {
	display: column;
	margin: 0 0 20px;
	padding: 10px 25px;
	width: 50%;
}

@media(max-width:480px){
  
  form{
      flex-direction: column;
      background: rgba(241, 241, 241, 0.43);
      margin-top: 5px;
      width: 90%;
      margin-left: 10px;
      border: 2px solid rgba(86, 37, 81, 0.53);
      font-family: 'Jacques Francois';
      font-style: normal;
      font-size: 15px;
      color: #22031f;
  }
  }
</style>
