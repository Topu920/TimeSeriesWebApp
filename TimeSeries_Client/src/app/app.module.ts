import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReadingModule } from './reading/reading.module';
import { ReadingsearchComponent } from './reading/readingsearch/readingsearch.component';
import { HttpClientModule } from "@angular/common/http";
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {ChartModule} from 'primeng/chart';
//import { ChartModule } from 'angular2-highcharts';
import { HighchartsChartModule } from 'highcharts-angular';
import { DatePipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    ReadingsearchComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    //ReadingModule,
   
    FormsModule,
    ReactiveFormsModule,
    BsDatepickerModule.forRoot(),
    HttpClientModule,
 
    BrowserAnimationsModule,
   ChartModule,
   HighchartsChartModule
  //ChartModule.forRoot(require('highcharts'))

    
    
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
