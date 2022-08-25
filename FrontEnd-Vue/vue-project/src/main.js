import { createApp } from 'vue'
import App from './App.vue'
import "./assets/global.css"
import PaginaInicial from './pages/PaginaInicial.vue'
import Agendamento from './pages/Agendamento.vue'
import AreaProfissional from './pages/AreaProfissional.vue'
import CadastroCliente from './pages/CadastroCliente.vue'
import CadastroProfissional from './pages/CadastroProfissional.vue'
import Historico from './pages/Historico.vue'
import Login from './pages/Login.vue'
import { createRouter, createWebHashHistory } from 'vue-router'

const router = createRouter({
    history: createWebHashHistory(),
    routes:[
    {
        path:'/',
        component: PaginaInicial
    },
    {
        path:'/agendamento',
        component: Agendamento
    },
    {
        path:'/areaprofissional',
        component: AreaProfissional
    },
    {
        path:'/cadastrocliente',
        component: CadastroCliente
    },
    {
        path:'/cadastroprofissional',
        component: CadastroProfissional
    },
    {
        path:'/historico',
        component: Historico
    },
    {
        path:'/login',
        component: Login
    }
]
})




const app = createApp(App)

app.use(router);

app.mount('#app')
