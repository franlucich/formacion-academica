import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { ModalLogoutComponent } from "./modal-logout/modal-logout.component";


@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [CommonModule, RouterOutlet, RouterLink, RouterLinkActive, ModalLogoutComponent]
})
export class AppComponent {
  title = 'fa-frontend';
}
