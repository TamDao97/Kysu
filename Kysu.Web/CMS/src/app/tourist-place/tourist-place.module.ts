import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TouristPlaceRoutingModule } from './tourist-place-routing.module';
import { TouristPlaceComponent } from './tourist-place.component';


@NgModule({
  declarations: [TouristPlaceComponent],
  imports: [
    CommonModule,
    TouristPlaceRoutingModule
  ]
})
export class TouristPlaceModule { }
