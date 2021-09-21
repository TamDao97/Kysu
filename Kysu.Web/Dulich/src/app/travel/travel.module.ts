import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TravelRoutingModule } from './travel-routing.module';
import { TravelComponent } from './travel.component';
import { SharedModule } from '../Shared/shared.module';


@NgModule({
  declarations: [TravelComponent],
  imports: [
    CommonModule,
    TravelRoutingModule,
    SharedModule
  ]
})
export class TravelModule { }
