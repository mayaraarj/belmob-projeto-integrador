export let ClienteService = {
    async Register (bodyCliente) {
        const configRegister = {
            method: 'POST',
            body: JSON.stringify(bodyCliente),
            headers: {
                'Content-type': 'application/json',
                'accept': 'text/plain'
            },
        }
        const response = await fetch('https://localhost:7261/Cliente/Cadastrar', configRegister);
        const novocliente = await response.json();
        console.log(novocliente);
        return novocliente;
    },
    async GetAll(){
        const response = await fetch('https://localhost:7261/Cliente/Listar');
        const clientes = await response.json();
        console.log(clientes);
        return clientes;
    },
    async Logar(dados){
        const configRegister = {
            method: 'POST',
            body: JSON.stringify(dados),
            headers: {
                'Content-type': 'application/json',
                'accept': 'text/plain'
            },
        }
        const response = await fetch('https://localhost:7261/Cliente/Login', configRegister);
        const id = await response.json();
        console.log(id);
        localStorage.setItem('clienteId',id);
        return id;
    },
    async Agendar(dados){
        const configRegister = {
            method: 'POST',
            body: JSON.stringify(dados),
            headers: {
                'Content-type': 'application/json',
                'accept': 'text/plain'
            },
        }
        console.log(JSON.stringify(dados))
        const response = await fetch('https://localhost:7261/Agendamento/Agendar', configRegister);
        const Agendamento = await response.json();
        console.log(Agendamento);
        return Agendamento;
    },
    async ListarHistorico(id){
        const response = await fetch('https://localhost:7261/Agendamento/ListarHistoricoCliente?id=' + id);
        const historico = await response.json();
        console.log(historico);
        return historico;
    } 

}