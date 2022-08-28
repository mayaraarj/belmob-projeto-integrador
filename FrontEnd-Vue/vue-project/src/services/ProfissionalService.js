export let ProfissionalService = {
    async Registrar (bodyCliente) {
        const configRegister = {
            method: 'POST',
            body: JSON.stringify(bodyCliente),
            headers: {
                'Content-type': 'application/json',
                'accept': 'text/plain'
            },
        }
        const response = await fetch('https://localhost:7261/Profissional/Cadastrar', configRegister);
        const novoProfissional = await response.json();
        console.log(novoProfissional);
        return novoProfissional;
    },
    async Listar(){
        const response = await fetch('https://localhost:7261/Profissional/Listar');
        const profissionais = await response.json();
        console.log(profissionais);
        return profissionais;
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
        const response = await fetch('https://localhost:7261/Profissional/Login', configRegister);
        const id = await response.json();
        console.log(id);
        localStorage.setItem('ProfissionalId',id);
        return id;
    },
    async Disponiveis (id){
        const response = await fetch('https://localhost:7261/Profissional/AgendamentosDisponiveis');
        const agendamentos = await response.json();
        console.log(agendamentos);
        return agendamentos;
    },
    async ProximosAgendamentos (id){
        const response = await fetch('https://localhost:7261/Profissional/AgendamentosProximos?Id=' + id);
        const agendamentos = await response.json();
        console.log(agendamentos);
        return agendamentos;
    },
    async Historico (id){
        const response = await fetch('https://localhost:7261/Profissional/AgendamentosPassados?Id=' + id);
        const agendamentos = await response.json();
        console.log(agendamentos);
        return agendamentos;
    },
    async Agendar (agendar) {
        const configRegister = {
            method: 'PUT',
            body: JSON.stringify(agendar),
            headers: {
                'Content-type': 'application/json',
                'accept': 'text/plain'
            },
        }
        const response = await fetch('https://localhost:7261/Profissional/AceitarAgendamento', configRegister);
        const novoProfissional = await response.json();
        console.log(novoProfissional);
        return novoProfissional;
    }    
} 