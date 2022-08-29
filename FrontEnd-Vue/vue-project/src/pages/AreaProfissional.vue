<script setup>
  import moment from 'moment'; 
  </script>
<template>
  <body>
    <nav aria-label="breadcrumb" class="breadcrumb">
      <ul>
        <li><span aria-current="page">Area Profissional</span></li>
      </ul>
    </nav>
    <main>
      <h1 class="titulo-principal">Área do Profissional</h1>
    </main>
    <section class="principal">
      <div class="containers">
        <p>Atendimentos disponíveis</p>
        <div class="informacoes">
          <div v-for="iten in agendamentos" class="agendamento">
            <p>Nome Cliente: {{ iten.clienteResponse.nome }}</p>
            <p>
              Endereço: {{ iten.clienteResponse.enderecos[0].logradouro }},
              {{ iten.clienteResponse.enderecos[0].bairro }}
            </p>
            <p>Data e Hora: {{ moment(iten.data).format('DD/MM/YYYY hh:mm') }}</p>
            <p>Serviço: {{ this.tipoServico(iten.tipoServico) }}</p>
            <p>Código do Agendamento: {{ iten.id }}</p>
            <button v-on:click="this.Agendar(iten.id)">Agendar</button>
          </div>
        </div>
      </div>
      <div class="containers">
        <p>Próximos agendamentos</p>
        <div class="informacoes">
          <div v-for="(iten,index) in proximosAgendamentos" class="agendamento">
            <p>Nome Cliente:{{ iten.clienteResponse.nome }}</p>
            <p>Endereço: {{ iten.endereco }}</p>
            <p>Data e Hora: {{ moment(iten.data).format('DD/MM/YYYY hh:mm') }}</p>
            <p>Serviço: {{ this.tipoServico(iten.tipoServico) }}</p>
            <button
              v-on:click="this.IniciarAgendamento(index)"
              :id="'btnAgendamento' + index"
            >
              Iniciar atendimento
            </button>
          </div>
        </div>
      </div>
      <div class="containers">
        <p>Histórico</p>
        <div class="informacoes">
          <div v-for="iten in historico" class="historico">
            <img src="../assets/imagens/Photo.svg" alt="" />
            <div>
              <p>Nome Cliente:{{ iten.clienteResponse.nome }}</p>
              <p>Endereço: {{ iten.endereco }}</p>
              <p>Data e Hora: {{ moment(iten.data).format('DD/MM/YYYY hh:mm') }}</p>
              <p>Serviço: {{ this.tipoServico(iten.tipoServico) }}</p>
              <p>
                Avaliação:
                <img src="../assets/imagens/startsAvaliacao.svg" alt="" />
              </p>
            </div>
          </div>
        </div>
      </div>
    </section>
  </body>
</template>
<script>
import { ProfissionalService } from "../services/ProfissionalService";

export default {
  data() {
    return {
      agendamentos: [],
      proximosAgendamentos: [],
      statusAgendamento: false,
      historico: []
    };
  },
  mounted() {
    ProfissionalService.Disponiveis().then(
      (response) => (this.agendamentos = response)
    );

    ProfissionalService.ProximosAgendamentos(1).then(
      (response) => (this.proximosAgendamentos = response)
    );

    ProfissionalService.Historico(1).then(
      (response) => (this.historico = response)
    );
  },
  methods: {
    Agendar: function (id) {
      var agendar = { idProfissional: 1, idAgendamento: id };
      ProfissionalService.Agendar(agendar);
      alert("Agendado");
      this.$router.go()
    },
    IniciarAgendamento: function (index) {
      this.statusAgendamento = !this.statusAgendamento;
      var element = document.getElementById("btnAgendamento" + index);
      element.innerText = this
        .statusAgendamento
        ? "Finalizar"
        : "Iniciar atendimento";

        element.className = this.statusAgendamento ? "greenButton" : ""

      
    },
    tipoServico: function (tipo) {
      if (tipo == 0) {
        return "Mãos";
      } else if (tipo == 1) {
        return "Pés";
      } else {
        return "Mãos e Pés";
      }
    }
  },
};
</script>
<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: "Jacques Francois";
}

body {
  background-image: url("../assets/imagens/unhas.jpg");
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center center;
  background-attachment: fixed;
  min-height: 100%;
}
a {
  color: inherit;
  text-decoration: inherit;
}

a:hover {
  color: rgb(235, 197, 222);
  text-decoration: underline;
}

.greenButton {
  color: white;
  background-color: green;
}

.breadcrumb ul {
  display: flex;
  flex-wrap: wrap;
  list-style: none;
  font-family: "Jacques Francois";
  margin: 10px 0 0 25px;
  padding: 0;
  font-size: 15px;
}

.breadcrumb li:not(:last-child)::after {
  display: inline-block;
  margin: 0 0.25rem;
  content: "»";
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
.comoFunciona {
  font-family: "Jacques Francois";
  font-size: 15px;
  margin-right: 20px;
}
.contato {
  font-family: "Jacques Francois";
  font-size: 15px;
  margin-right: 20px;
}

.servicos {
  font-family: "Jacques Francois";
  font-size: 15px;
  margin-right: 20px;
}

@media (max-width: 480px) {
  .header {
    flex-direction: column;
  }
  .comoFunciona,
  .contato,
  .servicos {
    margin-top: 10px;
  }
}

a {
  color: #562551;
  text-decoration: inherit;
}

.header__logo:hover {
  color: rgb(235, 197, 222);
  text-decoration: underline;
}

.a:hover {
  color: rgb(235, 197, 222);
  text-decoration: underline;
}

h1 {
  font-style: normal;
  font-weight: 400;
  font-size: 420%;
  line-height: 106px;
  /* identical to box height */
  text-align: center;
  color: #562551;
}

.area-prof {
  /*display: flex;
  width: 15%;
  justify-content: space-around;*/
  margin-left: 40px;
}

.area-prof span {
  color: #83507e;
}

.principal {
  display: flex;
  justify-content: center;
}

.containers {
  width: 28.125rem;
}

.historico {
  display: flex;
  height: 120px;
}

.agendamento{
  height: 120px;
}

.containers p:not(.informacoes p) {
  text-align: center;
  font-weight: 400;
  font-size: 24px;
  line-height: 42px;
  text-align: center;
  color: #562551;
}

.informacoes {
  height: 450px;
  background: rgba(255, 255, 255, 0.75);
  border: 2px solid #562551;
  border-radius: 1px;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
}

.agendamento p,
.historico div p {
  font-size: 15px;
  line-height: 20px;
  color: #000000;
  padding-left: 16px;
}

.agendamento,
.historico {
  width: 418px;
  background: #ffffff;
  border: 1px solid #562551;
  border-radius: 1px;
}

button {
  margin-left: 134px;
}

@media (max-width: 480px) {
  .principal {
    flex-direction: column;
  }
  form {
    flex-direction: column;
    background: rgba(241, 241, 241, 0.43);
    margin-top: 5px;
    width: 90%;
    margin-left: 10px;
    border: 2px solid rgba(86, 37, 81, 0.53);
    font-family: "Jacques Francois";
    font-style: normal;
    font-size: 15px;
    color: #22031f;
  }
}
</style>