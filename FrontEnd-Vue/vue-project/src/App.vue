<script setup>
</script>

<template>
   <header>
    <div class="header">
      <div class="header__logo">
          <span><RouterLink to="/">Belmob </RouterLink></span>
          <span class="linha">|</span>
      </div>   
      <div class="inicio"><RouterLink to="/">Início</RouterLink></div>
      <div class="entrar"><RouterLink to="/login">Entrar</RouterLink></div>
  </div>
    </header>

  <section class="body-container">
    <RouterView/>
  </section>
</template>

<style scoped>
.header {
  display: flex;
  border-bottom: 1px solid #562551;
  background-color: #BB92B7;
  background-position: 100%;
  align-items: center;
  align-content: center;
}
.header__logo {
  font-family: 'Hurricane';
  font-size: 50px;
  margin: 0 25px;
  color:  #562551;;
}
.linha{
  font-family: 'Jacques Francois';
  font-size: 30px;
  margin-left: 5px;
}

.header__logo:hover{

  color: rgb(235, 197, 222);
  
  text-decoration:underline;
  }

.entrar, .inicio{
  font-family: 'Jacques Francois';
  font-size: 15px;
  margin-right: 20px;
}

.entrar:hover{
  color: rgb(235, 197, 222);
  text-decoration:underline;
  }
  
.inicio:hover{
    color: rgb(235, 197, 222);
    text-decoration:underline;
}

a{
  color: inherit;
  text-decoration: inherit; 
}

a:hover{
  color: rgb(235, 197, 222);
  text-decoration:underline; 
}

.body-container {
  height: calc(100vh - 76px);
}

</style>
