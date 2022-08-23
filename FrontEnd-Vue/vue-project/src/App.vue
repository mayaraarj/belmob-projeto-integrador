

<script setup>
import PaginaInicialVue from './pages/PaginaInicial.vue';
import PaginaInicial from './pages/PaginaInicial.vue';
</script>

<template>
   <header>
    <div class="header">
      <div class="header__logo">
          <span><a href='#'></a>BelMob</span>
          <span class="linha">|</span>
      </div>   
      <div class="entrar"><a href='#'></a>Entrar</div>
  </div>
    </header>
  <PaginaInicial></PaginaInicial>
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

.a:hover{

  color: rgb(235, 197, 222);
  
  text-decoration:underline;
  
  }

.entrar{
  font-family: 'Jacques Francois';
  font-size: 15px;
  margin-right: 20px;
}

.entrar:hover{

  color: rgb(235, 197, 222);
  
  text-decoration:underline;
  
  }
  
  a:hover{
  
  color: rgb(235, 197, 222);
  
  text-decoration:underline;
  
  }

</style>
