<template>
<body>
    <nav aria-label="breadcrumb" class="breadcrumb">
        <ul>
              <li><RouterLink class="a" to="/historico">Histórico</RouterLink></li>
            <li><span aria-current="page">Novo Agendamento</span></li>
        </ul>
    </nav>

    <div class="titulo-novoAgendamento">
        <h1>Novo Agendamento</h1>
    </div>

    <main>
        <div class="card-container">
            <div class="card">
                <div class="card-title">Selecione um dos serviços</div>

                <div class="card-info">                    
                    <div class="card-maos">
                        <button @click="tipoServico == maos" class="botao-servico">Mãos R$ 40,00</button>
                    </div>

                    <div class="card-pes">
                        <button @click="tipoServico == pes" class="botao-servico">Pés R$ 40,00</button>
                    </div>

                    <div class="card-maosPes">
                        <button @click="tipoServico == maospes" class="botao-servico">Mãos e Pés R$ 60,00</button>
                    </div>
                </div>
            </div>

            <div class="card">
                <div class="card-title">Novo Agendamento</div>

                <div class="card-info">
                    <form class="card-endereco">
                        <div class="input-icons">
                            <i class="fas fa-map-marker-alt icon"></i>
                            <input class="input-field" type="text" placeholder="Onde será o atendimento?">
                        </div>
                    </form>

                    <form class="card-dataHora">
                        <div class="input-icons">
                            <i class="fas fa-calendar-alt icon"></i>
                            <input v-model="data" class="input-field" placeholder="Escolha a data e a hora do atendimento" 
                                type="text" onfocus="(this.type='date')" onblur="(this.type='text')" id="date" />
                        </div>
                    </form>

                    <div class="card-pagamento">
                        <div class="input-icons">
                            <i class="fas fa-sack-dollar icon"></i>
                            <input class="input-field input-comoPagar" type="text" placeholder="Como deseja pagar?" readonly>

                            <label class="card-pixCartao">
                                <input type="radio" name="opcaoPagamento" value="pix" checked="checked">
                                <i class="fa-brands fa-pix icon-pagamento"></i>
                                <span class="texto-pixCartao">Pix</span>
                                <span class="checkmark"></span>
                            </label>

                            <label class="card-pixCartao">
                                <input type="radio" name="opcaoPagamento" value="cartao">
                                <i class="fas fa-credit-card icon-pagamento"></i>
                                <span class="texto-pixCartao">Cartão</span>
                                <span class="checkmark"></span>
                            </label>
                        </div>
                    </div>

                    <div class="card-resumoTotal">
                        <div class="card-resumo">
                            <div class="texto-resumo">RESUMO</div>
                        </div>

                        <div class="card-totalCifrao">
                            <div class="card-total">
                                <div class="texto-total">TOTAL</div>
                            </div>

                            <div class="card-cifrao">
                                <div class="texto-cifrao">R$</div>
                            </div>
                        </div>
                    </div>      
                    
                    <div class="card-botaoAgendar">
                        <button @click="cad()" class="botao-agendar">Agendar</button>
                    </div>
                </div>                
            </div>
        </div>
    </main>
</body>
</template>

<script>
// import { ClienteService } from '../services/ClienteService';

// export default {
//     data() {
//         return {
//            data: null,
//            tipoServico: null,
//            tipoPagamento: null,
//            adicionarCupon: null
//         }
//     },
//     methods: {
//         cad: function(){
//             var cadastroUsuario = {
//             idCliente: 1,
//             data: "2022-08-27T23:46:52.438Z",
//             tipoServico: 0,
//             tipoPagamento: 0
//             }
//             console.log(cadastroUsuario);
//             const ok = ClienteService.Agendar(cadastroUsuario).then(i=> i);
//             if(ok){
//                 alert("Cadastro efetuado com sucesso!");
//             }
//         }
//     }
//}

</script>

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
    font-family: 'Jacques Francois';
    color: #562551;
}

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
.inicio{
    font-size: 15px;
    margin-right: 20px;
}

a{
    color: inherit;
    text-decoration: inherit; 
}

a:hover{
    color: rgb(235, 197, 222);
    text-decoration:underline;
}

.breadcrumb ul {
    display: flex;
    flex-wrap: wrap;
    list-style: none;
    font-family: 'Jacques Francois';
    margin: 10px 0 0 25px;
    padding: 0;
    font-size: 15px;
}

.breadcrumb li:not(:last-child)::after {
    display: inline-block;
    margin: 0 .25rem;
    content: "»";
}

h1 {
    text-align: center;
    font-size: 60px;
    padding: 0;
    margin: 25px 25px;
}

.card-container {
    display: flex;
    justify-content: center;
    align-items: center;
}

.card {
    display: flex;
    flex-direction: column;
    justify-content: top;
    align-items: center;
    padding: 0;
    margin: 0;
    width: 450px;
    height: 650px;
    position: relative;
    background-color: transparent;
    border: 1px solid #562551;
    border-style: none;
    padding: 20px;
    transition:all .3s ease-in;
}

.card .card-title {
    font-size: 30px;
}

.card-info {
    display: flex;
    flex-direction: column;
    width: 400px;
    height: 520px;
    border: 1px solid #562551;
    background-color: #fff;
    gap: 20px;
    padding: 20px;
}

.card-maos {
    background-image: url("../assets/imagens/maos.jpg");
}

.card-pes {
    background-image: url("../assets/imagens/pes.jpg");
}

.card-maosPes {
    background-image: url("../assets/imagens/maosPes.jpg");
}

.card-maos, .card-pes, .card-maosPes {
    background-repeat: no-repeat;
    background-position: center;
    background-size: cover;
    display: flex;
    height: 150px;
    border: 1px solid #562551;
    padding: 10px;    
    justify-content: center;
    align-items: center;
}

.botao-servico {
    background: none;
    border: none;
    color: #562551;
    font-weight:700;  
    font-size: 30px;
    text-shadow: 2px 0 #fff, -2px 0 #fff, 0 2px #fff, 0 -2px #fff,
    1px 1px #fff, -1px -1px #fff, 1px -1px #fff, -1px 1px #fff; 
}

.botao-servico:focus {
    color: #BB92B7;
}

.input-icons i {
    position: absolute;
}

.input-icons {
    width: 100%;
}

.icon, .icon-pagamento {
    padding: 10px;
    color: #BB92B7;
    text-align: center;
}

.input-field {
    width: 100%;
    padding: 5px 30px;
    text-align: left;
    color: #562551;
}

input::placeholder {
    font-size: 15px;
    color: #562551;
}

.input-comoPagar {
    border: none;
}

.card-pixCartao {
    display: flex;
    position: relative;
    margin: 10px;
    padding-left: 35px;
    cursor: pointer;
    font-size: 15px;
    -webkit-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}

.card-pagamento {
    border: 1px solid #562551;
}

.input-comoPagar {
    border-style: none;
    border-bottom: 1px solid #562551;
    
}

.icon-pagamento {
    color: #BB92B7;
    min-width: 50px;
    left: 10px;
    top: 5px;
    padding: 0;
    margin: 0;
}

.card-pixCartao input {
    position: relative;
    opacity: 0;
    cursor: pointer;
    height: 0;
    width: 15px;
}

.checkmark {
    position: absolute;
    top: 0;
    left: 0;
    height: 20px;
    width: 20px;
    border: 1px solid #562551;
}

.card-pixCartao:hover input~.checkmark {
    background-color: #BB92B7;
}

.card-pixCartao input:checked~.checkmark {
    background-color: #BB92B7;
}

.checkmark:after {
    content: "";
    position: relative;
    display: none;
}

.card-pixCartao input:checked~.checkmark:after {
    display: block;
}

.card-pixCartao .checkmark:after {
    left: 7px;
    top: 3px;
    width: 4px;
    height: 10px;
    border: solid white;
    border-width: 0 3px 3px 0;
    -webkit-transform: rotate(45deg);
    -ms-transform: rotate(45deg);
    transform: rotate(45deg);
}

.card-resumoTotal {
    display: flex;
    justify-content: center;
    align-items: center;
    position: relative;
    border: 1px solid #562551;
    border-radius: 3px;
    height: 150px;
    margin-top: 0;
    font-size: 15px;
}

.card-resumo {
    display: flex;
    justify-content: center;
    align-items: center;
    width: 50%;

}

.card-totalCifrao{
    display: flex;
    flex-direction: column;
    justify-content: center;
    gap: 30px;
    align-items: center;
    width: 100%;
}

.card-botaoAgendar {
    display: flex;
    justify-content: center;
    align-self: center;
    position: relative;
    border: 1px solid #562551;
    background-color: #BB92B7;    
    border-radius: 3px;
    text-align: center;
    height: 40px;
    width: 50%;
    transition-duration: 0.4s;    
}

.botao-agendar {
    background: none;
    color: inherit;
    border: none;
    padding: 0;
    font: inherit;
    cursor: pointer;
    outline: inherit;
    font-size: 20px;
}

.card-botaoAgendar:hover{
    color: white;
}


@media(max-width:480px){
    .header{
        flex-direction: column;
    }
    .entrar{
        margin-top: 10px;
    }
}

@media screen and (max-width: 600px) {
    .card-info {
        width: 300px;
    }
    .card-container{
        flex-direction: column;
        }
  }
</style>