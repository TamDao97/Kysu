import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TouristPlaceComponent } from './tourist-place.component';

const routes: Routes = [{ path: '', component: TouristPlaceComponent },];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TouristPlaceRoutingModule { }
