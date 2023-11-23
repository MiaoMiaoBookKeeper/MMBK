import { Component } from '@angular/core';
import { FlashService } from 'src/app/sharing/services/flash.service';

@Component({
  selector: 'app-flash',
  templateUrl: './flash.component.html',
  styleUrls: ['./flash.component.scss']
})
export class FlashComponent {

  currentValue:number = 0;
  loading = false;

  constructor(
    private fs: FlashService
  )
  {}

  load(){
     this.fs.get().subscribe((r) => {
      this.currentValue = r;
     }).add(console.log("load done"));
  }

  add(){
    this.fs.add(this.currentValue).subscribe((r) => {
      this.currentValue = r;
     }).add(console.log("add done"));;

  }
  
}
