<template>
<body class="body">
    <div class="formulariosLogin">
        <div class="formularioCliente">
            <form class="formCliente">
                <h1 class="titulo">Área Do Cliente</h1>
                <div class="form-group">
                <label for="exampleInputEmail1">Email</label>
                <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Seu email">
                <small id="emailHelp" class="form-text text-muted"></small>
                </div>
                <div class="form-group">
                <label for="exampleInputPassword1">Senha</label>
                <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Senha">
                </div>
                <button type="submit" class="btn btn-primary">Login</button>
                <button type="submit" class="btn btn-primary">Cadastro</button>
            </form>
        </div>
        
        <div class="formularioProfissional">
            <form class="formProfissional">
                <h1 class="titulo">Área Do Profissional</h1>
                <div class="form-group">
                <label for="exampleInputEmail1">Email</label>
                <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Seu email">
                <small id="emailHelp" class="form-text text-muted"></small>
                </div>
                <div class="form-group">
                <label for="exampleInputPassword1">Senha</label>
                <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Senha">
                </div>
                <button type="submit" class="btn btn-primary">Login</button>
                <button type="submit" class="btn btn-primary">Cadastro</button>
            </form>
        </div>
    </div>
</body>
</template>

<style>
*{box-sizing:content-box}
.body{
    margin:0;
    padding:0;
    height: 100%;
    max-width: 100%;
    max-height: 100%;
}
.formulariosLogin{
    display: flex;
}
#exampleInputEmail1, #exampleInputPassword1{
    width: 60%;
    padding: 5px 30px;
    text-align: left;
    color: #562551;
    margin-left: 20px;
}
.form-group{
    display: flex;
    margin: 0 10px 20px 0;
    justify-content: end;
}
.formularioCliente{
    width: 50%;
    background-image: url(../assets/imagens/beauty.png);
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center center;
    border: 1px solid rgba(86, 37, 81, 0.53);
}
.formularioProfissional{
    width: 50%;
    background-image: url(../assets/imagens/manicure.png);
    background-repeat: no-repeat;
    background-size: cover;
    background-position: center center;
    border: 1px solid rgba(86, 37, 81, 0.53);
}
.titulo{
    margin-bottom: 0px;
}
.formCliente{
    margin-top: 100%;
    font-family: 'Jacques Francois';
    font-size: 20px;
    color: white;
    text-align:end;
}
.formProfissional{
    margin-top: 100%;
    font-family: 'Jacques Francois';
    font-size: 20px;
    color: #562551;
    text-align:end;
}
.btn-primary{
    background-color: #562551;
    font-family: 'Jacques Francois';
    font-size: 20px;
    border: 1px solid #FFFFFF;
    color: white;
    margin-top: 5px;
}
@media(max-width:480px){
    .header{
        flex-direction: column;
    }
    .entrar{
        margin-top: 10px;
    }
.formularios{
    flex-direction: column;
}

.formularioCliente{
    width: 100%;
    background-size: cover;
    background-position: center center;
}
.formularioProfissional{
    width: 100%;
    background-size: cover;
    background-position: center center;
}
}
</style>
<script>
export default{
    name: "Login",
};
</script>