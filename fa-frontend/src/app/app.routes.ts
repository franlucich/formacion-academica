import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component'
import { FormacionAcademicaComponent } from './formacion-academica/formacion-academica.component';
import { TesisPosgradoComponent } from './tesis-posgrado/tesis-posgrado.component';
import { PracticaProfesionalizanteComponent } from './practica-profesionalizante/practica-profesionalizante.component';
import { EnsayoCatedraComponent } from './ensayo-catedra/ensayo-catedra.component';

export const routes: Routes = [

    { path: 'home', component: HomeComponent },
    { path: 'formacion-academica', component: FormacionAcademicaComponent, 
    children: [
        { path: 'tesis-posgrado', component: TesisPosgradoComponent, pathMatch: 'full' },
        { path: 'practica-profesionalizante', component: PracticaProfesionalizanteComponent, pathMatch: 'full' },
        { path: 'ensayo-catedra', component: EnsayoCatedraComponent, pathMatch: 'full' }
    ]},
];
