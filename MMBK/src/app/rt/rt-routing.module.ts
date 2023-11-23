import { NgModule } from '@angular/core';
import { Routes, RouterModule} from '@angular/router';
import { RtComponent } from './rt.component';
import { FlashComponent } from './flash/flash.component';

import { DashboardComponent } from './dashboard/dashboard.component';

const routes: Routes = [
  {
    path: '',
    component: RtComponent,
    children: [
      { path: '', redirectTo: 'flash', pathMatch: 'full' },
      { path: 'flash',
        children: [
          {path:'',component: FlashComponent},
          {path:'dashboard',component: DashboardComponent}
        ]
      }
    ]
  }
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)

  ],
  exports: [
    RouterModule
]
})
export class RtRoutingModule { }
