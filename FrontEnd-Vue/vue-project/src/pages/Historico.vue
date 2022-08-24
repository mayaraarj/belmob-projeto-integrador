<script setup></script>

<template>
  <body>
    <nav aria-label="breadcrumb" class="breadcrumb">
      <ul>
        <li><a href="#">Início</a></li>
        <li><a href="../pages/novoAgendamento.html">Novo Agendamento</a></li>
        <li><span aria-current="page">Histórico</span></li>
      </ul>
    </nav>
    <main>
      <div class="titulo-historico">
        <h1>Histórico</h1>
      </div>

      <div class="card">
        <div class="card-data">
          <span>Sab, 09 julho 2022 » Horário 10:00h</span>
        </div>

        <div class="card-body">
          <div class="card-foto">
            <img src="../assets/imagens/Photo.svg" class="img-foto" />
          </div>

          <div class="card-info">
            <span>Nome: { nome }</span>
            <span>Endereço: { endereco }</span>
            <span>Serviço: { servico }</span>

            <div class="card-avaliacao">
              <ul class="rate-area">
                <input type="radio" id="5-star" name="crating" value="5" />
                <label for="5-star" title="Amazing">5 stars</label>
                <input type="radio" id="4-star" name="crating" value="4" />
                <label for="4-star" title="Good">4 stars</label>
                <input type="radio" id="3-star" name="crating" value="3" />
                <label for="3-star" title="Average">3 stars</label>
                <input type="radio" id="2-star" name="crating" value="2" />
                <label for="2-star" title="Not Good">2 stars</label>
                <input
                  type="radio"
                  id="1-star"
                  required=""
                  name="crating"
                  value="1"
                  aria-required="true"
                />
                <label for="1-star" title="Bad">1 star</label>
                <span class="texto-avaliacao">Avaliação: { avaliacao }</span>
              </ul>
            </div>

            <div class="card-botao">
              <button id="botao-agendarNovamente">Agendar Novamente</button>
            </div>
          </div>
        </div>
      </div>

      <div class="card">
        <div class="card-data">
          <span>Sab, 09 julho 2022 » Horário 10:00h</span>
        </div>

        <div class="card-body">
          <div class="card-foto">
            <img src="../assets/imagens/Photo.svg" class="img-foto" />
          </div>

          <div class="card-info">
            <span>Nome: { nome }</span>
            <span>Endereço: { endereco }</span>
            <span>Serviço: { servico }</span>

            <div class="card-avaliacao">
              <ul class="rate-area">
                <input type="radio" id="5-star" name="crating" value="5" />
                <label for="5-star" title="Amazing">5 stars</label>
                <input type="radio" id="4-star" name="crating" value="4" />
                <label for="4-star" title="Good">4 stars</label>
                <input type="radio" id="3-star" name="crating" value="3" />
                <label for="3-star" title="Average">3 stars</label>
                <input type="radio" id="2-star" name="crating" value="2" />
                <label for="2-star" title="Not Good">2 stars</label>
                <input
                  type="radio"
                  id="1-star"
                  required=""
                  name="crating"
                  value="1"
                  aria-required="true"
                />
                <label for="1-star" title="Bad">1 star</label>
                <span class="texto-avaliacao">Avaliação: { avaliacao }</span>
              </ul>
            </div>

            <div class="card-botao">
              <button id="botao-agendarNovamente">Agendar Novamente</button>
            </div>
          </div>
        </div>
      </div>
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
  background-image: url("../assets/imagens/unhas.jpg");
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center center;
  background-attachment: fixed;
  font-family: "Jacques Francois";
  color: #562551;
}

.header {
  display: flex;
  border-bottom: 1px solid #562551;
  background-color: #bb92b7;
  background-position: 100%;
  align-items: center;
  align-content: center;
}
.header__logo {
  font-family: "Hurricane";
  font-size: 50px;
  margin: 0 25px;
  color: #562551;
}
.linha {
  font-family: "Jacques Francois";
  font-size: 30px;
  margin-left: 5px;
}
.inicio {
  font-size: 15px;
  margin-right: 20px;
}

a {
  color: inherit;
  text-decoration: inherit;
}

a:hover {
  color: rgb(235, 197, 222);
  text-decoration: underline;
}

.breadcrumb ul {
  display: flex;
  flex-wrap: wrap;
  list-style: none;
  margin: 10px 0 0 25px;
  padding: 0;
  font-size: 15px;
}

.breadcrumb li:not(:last-child)::after {
  display: inline-block;
  margin: 0 0.25rem;
  content: "»";
}

h1 {
  text-align: center;
  font-size: 60px;
  padding: 0;
  margin: 25px 25px;
}

main {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}

.card {
  display: flex;
  margin: 0 0 25px 0;
  width: 600px;
  border: 1px solid #562551;
  flex-wrap: wrap;
  justify-content: center;
}

.card-data {
  font-size: 20px;
  padding: 10px 0 0 20px;
}

img {
  float: left;
  max-width: 100%;
  max-height: 100%;
}

.card-foto {
  position: relative;
  height: 150px;
  width: 150px;
  border: 1px solid #562551;
  border-radius: 5px;
}

.card-foto .img-foto {
  height: 100%;
  width: 100%;
  object-fit: cover;
}

.card-body {
  display: flex;
  padding: 20px;
}

.card-info {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  margin-left: 20px;
  justify-content: center;
  font-size: 20px;
}

.rate-area {
  text-align: center;
  border-style: none;
  margin: 0;
  padding: 0;
}

.rate-area:not(:checked) > input {
  position: absolute;
  top: -9999px;
}

.rate-area:not(:checked) > label {
  float: right;
  width: 0.8em;
  overflow: hidden;
  white-space: nowrap;
  cursor: pointer;
  font-size: 20px;
  color: #bb92b7;
  margin-left: 5px;
}

.rate-area:not(:checked) > label:before {
  content: "★";
}

.rate-area > input:checked ~ label {
  color: #562551;
  text-shadow: none;
}

.rate-area:not(:checked) > label:hover,
.rate-area:not(:checked) > label:hover ~ label {
  color: #562551;
}

.rate-area > input:checked + label:hover,
.rate-area > input:checked + label:hover ~ label,
.rate-area > input:checked ~ label:hover,
.rate-area > input:checked ~ label:hover ~ label,
.rate-area > label:hover ~ input:checked ~ label {
  color: #562551;
  text-shadow: none;
}

.rate-area > label:active {
  position: relative;
  top: 0px;
  left: 0px;
}

.card-botao {
  display: flex;
  justify-content: center;
  align-self: center;
  border: 1px solid #562551;
  background-color: #bb92b7;
  border-radius: 3px;
  text-align: center;
  height: 40px;
  width: 200px;
  transition-duration: 0.4s;
  margin-top: 10px;
}

#botao-agendarNovamente {
  background: none;
  color: inherit;
  border: none;
  padding: 0;
  font: inherit;
  cursor: pointer;
  outline: inherit;
  font-size: 20px;
}

.card-botao:hover {
  color: white;
}

@media (max-width: 480px) {
  .header {
    flex-direction: column;
  }
  .entrar {
    margin-top: 10px;
  }
}
</style>
