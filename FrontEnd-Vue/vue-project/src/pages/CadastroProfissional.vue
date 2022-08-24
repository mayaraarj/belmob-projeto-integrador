<template>
<body class="body">   
    <nav aria-label="breadcrumb" class="breadcrumb">
        <ul>
            <li><a href='#'>Início</a></li>
            <li><span class="a" aria-current="page">Entrar</span></li>
            <li><span class="a" aria-current="page">Cadastro</span></li>
        </ul>
    </nav>
    <div class="formularios">
        <div class="sub_titulo">Dados Cadastrais</div>
        <div class="form">
            <div class="dadosCadastrais">
                <label for="nome">Nome:* </label>
                <input type="nome" class="form-control" id="nome">
                <label for="sobrenome">Sobrenome:* </label>
                <input type="name" class="form-control" id="sobrenome">
                <label for="sobrenome">Sexo:* </label>
                    <select class="custom-select">
                        <option selected>Escolha uma opção</option>
                        <option value="1">Feminino</option>
                        <option value="2">Masculino</option>
                        <option value="3">Prefiro não informar</option>
                    </select>
                        <label for="cpf">CPF:* </label>
                        <input type="number" class="form-control" id="cpf"> 
                        <label for="telefone">Telefone:</label>
                        <input type="number" class="form-control" id="telefone">
                        <label for="celular">Celular:* </label>
                        <input type="number" class="form-control" id="celular">
                        <label for="nascimento">Nascimento </label>
                        <input type="date" class="form-control" id="Nascimento">  
            </div>
                   
                    <div class="endereco">
                        <label for="cep">CEP:* </label>
                        <input type="number" class="form-control" id="cep">
                        <label for="logradouro">Logradouro:* </label>
                        <input type="name" class="form-control" id="logradouro">
                        <label for="numero">Numero:* </label>
                        <input type="number" class="form-control" id="numero">
                        <label for="complemento">Complemento:</label>
                        <input type="name" class="form-control" id="complemento">
                        <label for="referencia">Referencia: </label>
                        <input type="name" class="form-control" id="referencia">
                        <label for="bairro">Bairro:* </label>
                        <input type="name" class="form-control" id="bairro"> 
                         <label for="estado">Estado:* </label>
                        <select class="custom-select">
                            <option selected>Escolha uma opção</option>
                            <option value="1">SP</option>
                            <option value="2">RJ</option>
                            <option value="3">MG</option>
                        </select>
                    </div>
        </div>
            <div class="sub_titulo">Email e senha:*</div>
            <div class="form">
                <div class="email">
                    <label for="email">Email:* </label>
                    <input type="email" class="form-control" id="email">
                    <label for="emailreply">Digite novamente seu Email:* </label>
                    <input type="name" class="form-control" id="emailreply">
                </div>
                <div class="senha">
                    <label for="senha">Senha:* </label>
                    <input type="password" class="form-control" id="senha">
                    <label for="emailreply">Digite novamente sua senha:* </label>
                    <input type="password" class="form-control" id="senhareply">
                </div>
            </div>
            <div class="sub_titulo">Dados bancários:*</div>
            <div class="form">
                <div class="dadosBancarios">
                        <label for="email">Banco:* </label>
                        <input type="email" class="form-control" id="email">
                        <label for="email">Agencia:* </label>
                        <input type="email" class="form-control" id="email">
                </div>
                <div class="tipoDeConta">
                    <label for="emailreply">Conta:* </label>
                        <input type="name" class="form-control" id="emailreply">
                        <div class="form-check">
                            <input type="radio" name="exampleRadios" id="exampleRadios1" value="opcao1" checked>
                            <label for="exampleRadios1">
                            Corrente
                            </label>
                            <input type="radio" name="exampleRadios" id="exampleRadios2" value="opcao2">
                            <label for="exampleRadios2">
                            Poupança
                            </label>
                        </div>
                        <button type="button" class="btn btn-primary btn-lg">Finalizar</button>
                </div>
            </div>
        </div>
</body>
</template>

<style>
.body{
    background-image: url(../assets/imagens/unhas.jpg);
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center;
    margin:0;
    padding:0;
}
h1 {
    margin: 0;
}
.header__linha {
    font-size: 10px;
    margin-left: 25px;
}
a{
    color: #562551;
    text-decoration: inherit; 
}
.header__logo:hover{
    color: rgb(235, 197, 222);
    text-decoration:underline;
}
.a:hover{
    color: rgb(235, 197, 222);
    text-decoration:underline;
}
.entrar:hover{
    color: rgb(235, 197, 222);
    text-decoration:underline;
}
a:hover{
    color: rgb(235, 197, 222);
    text-decoration:underline;
}
.breadcrumb ul {
    color: #562551;
    display: flex;
    flex-wrap: wrap;
    list-style: none;
    margin: 10px 0 0 25px;
    padding: 0;
    font-size: 15px;
}
.breadcrumb li:not(:last-child)::after {
    display: inline-block;
    margin: 0 .25rem;
    content: "»";
}

#exampleRadios2{
    margin-left: 10px;
}
.formularios{
    display: flex;
    flex-direction: column;
    background: rgba(241, 241, 241, 0.43);
    margin-top: 5px;
    width: 90%;
    margin-left: 50px;
    border: 2px solid rgba(86, 37, 81, 0.53);
    font-family: 'Jacques Francois';
    font-style: normal;
    font-size: 15px;
    color: #22031f;
}
.form{
    display: flex;
}

.sub_titulo{
    text-align: center;
    font-family: 'Jacques Francois';
    font-style: normal;
    font-size: 20px;
    color: #562551;
}
.dadosCadastrais, .endereco, .email, .senha, .dadosBancarios, .tipoDeConta{
    width: 50%;
    display: flex;
    margin-right: 10px;
    flex-direction: column;
    margin-left: 10px;
}
.btn-lg{
    margin: 15px;
    background: #22031f;
    text-align: center;
    font-family: 'Jacques Francois';
    font-style: normal;
    font-size: 20px;
    color: white;
    margin-right: auto;
}
.estado{
    margin-top: 10px;
}
.dados{
    display: flex;
}
@media(max-width:480px){
.header{
    flex-direction: column;
}
.comoFunciona, .contato, .servicos{
    margin-top: 10px;
}
.formularios{
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
.form{
    flex-direction: column;
}

.sub_titulo{
    margin-top: 20px;
    text-align: center;
    margin-bottom: 20px;
}
.dadosCadastrais, .endereco, .email, .senha, .dadosBancarios, .tipoDeConta{
    width: 90%;
    display: flex;
    flex-direction: column;
    margin-left: 10px;
}
}
</style>
<script>
export default{
    name: "CadastroProfissional",
};
</script>