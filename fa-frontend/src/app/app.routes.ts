import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component'
import { FormacionAcademicaComponent } from './formacion-academica/formacion-academica.component';
import { TesisPosgradoComponent } from './tesis-posgrado/tesis-posgrado.component';
import { PracticaProfesionalizanteComponent } from './practica-profesionalizante/practica-profesionalizante.component';
import { EnsayoCatedraComponent } from './ensayo-catedra/ensayo-catedra.component';
import { TesinaLicenciaturaComponent } from './tesina-licenciatura/tesina-licenciatura.component';
import { ProyectoFinalIngenieriaComponent } from './proyecto-final-ingenieria/proyecto-final-ingenieria.component';
import { PracticaSupervisadaComponent } from './practica-supervisada/practica-supervisada.component';

export const routes: Routes = [

    { path: 'home', component: HomeComponent },
    { path: 'formacion-academica', component: FormacionAcademicaComponent, 
    children: [
        { path: 'tesis-posgrado', component: TesisPosgradoComponent, pathMatch: 'full' },
        { path: 'practica-profesionalizante', component: PracticaProfesionalizanteComponent, pathMatch: 'full' },
        { path: 'ensayo-catedra', component: EnsayoCatedraComponent, pathMatch: 'full' },
        { path: 'tesina-licenciatura', component: TesinaLicenciaturaComponent, pathMatch: 'full' },
        { path: 'proyecto-final-ingenieria', component: ProyectoFinalIngenieriaComponent, pathMatch: 'full' },
        { path: 'practica-supervisada', component: PracticaSupervisadaComponent, pathMatch: 'full' }
    ]},
];
