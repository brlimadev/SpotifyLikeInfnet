import { Component } from '@angular/core';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import { BandaService } from '../services/banda.services';
import { Banda } from '../model/banda';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [MatButtonModule, MatCardModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {

  bandas = null;

    constructor(private bandaService: BandaService){


    }

    ngOnInit(): void{
      this.bandaService.getBanda().subscribe(response => {
        this.bandas = response as any;
      })
    }

}

// Dentro de home.component.ts Criar um construtor e injetar o meu servico 

// Criar uma variavel pra receber a banda