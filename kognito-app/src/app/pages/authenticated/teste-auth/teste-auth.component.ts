import { Component, OnInit } from '@angular/core';
import { PlaceHolderService } from 'src/app/services/placeHolder.service';

@Component({
  selector: 'app-teste-auth',
  templateUrl: './teste-auth.component.html',
  styleUrls: ['./teste-auth.component.scss'],
})
export class TesteAuthComponent implements OnInit {
  constructor(private _service: PlaceHolderService) {}
  ngOnInit(): void {
  }

}
