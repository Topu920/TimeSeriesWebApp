import { Component, EventEmitter, OnInit, Output } from "@angular/core";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Readingmodel } from '../model/readingmodel.model';
import { ReadingserviceService } from '../services/readingservice.service';
import { BsDatepickerConfig } from "ngx-bootstrap/datepicker";

@Component({
  selector: 'app-readingsearch',
  templateUrl: './readingsearch.component.html',
  styleUrls: ['./readingsearch.component.scss']
})
export class ReadingsearchComponent implements OnInit {
  datePickerConfig: Partial<BsDatepickerConfig>;
  readingSearchForm: FormGroup;
  readingmodel: Readingmodel;
  currentDate = null;
  BuildingList: any[] = [];
  ObjectList: any[] = [];
  DataFieldList: any[] = [];
  basicData: any;
  data: any;
 
  
  readDataList: any[] = [];
  valueData: number[] = [];
  labelData: any[] = [];
  public basicOptions = {
    scales: {
      yAxis: {  
        min:0,        
       max:30,
          ticks: {
            beginAtZero: false,
            minSize:0,
            
            stepSize: 1
          }
        
     }
    }
  }
  constructor(public service: ReadingserviceService,private fb: FormBuilder) { 
    
  }
  
  ngOnInit(): void {
    
    this.service.GetReadingAllData()
    .subscribe(readDataList => {
      this.readDataList = readDataList as any[];
      console.log();
      let i = 0;
      let j = 0;
      for (i = 0; i < this.readDataList.length; i++) {
        this.labelData.push(this.readDataList[i].name);
        this.valueData.push(this.readDataList[i].count);
      }
      
      
      this.data = {
       
        labels: this.labelData,
        

        datasets: [{
          label:"",
         minRange:0,
          data: this.valueData,
          
          fill:false,
          backgroundColor: 'brown',
          borderColor: 'brown',
          lineTension: 1,
          
                borderWidth: 1.5
                
               
        }]
       
      }
     
    });
    
    
   
  
    this.datePickerConfig = Object.assign(
      {},
      {
        dateInputFormat: "DD/MMM/YYYY",
        containerClass: "theme-dark-blue",
        showWeekNumbers: false,
      }
    );
    this.CreateReadingSearchForm();
   
  }

  CreateReadingSearchForm() {
    if (this.readingmodel) {
      this.readingSearchForm = this.fb.group({
        buildingId: [this.readingmodel.buildingId],
        dataId: [this.readingmodel.dataId],
        objectId: [this.readingmodel.objectId],
        fDate: [this.readingmodel.fDate],
        tDate: [this.readingmodel.tDate]
      });
    }
    else {
      this.onClear();
    }
  }
  onClear(): void {
    this.readingSearchForm = this.fb.group({
      buildingId: [0],
      dataId: [0],
      objectId: [0],
      fDate: [null, this.currentDate],
      tDate: [null],
    });
   
    this.GetBuildingData();
    this.GetObjcet();
    this.GetDataField();
  }


  GetBuildingData() {
    this.service.getBuildingData().subscribe(res => {
      this.BuildingList = res as any[];
    }, error => {
      console.log(error);
    })
  }

  GetObjcet() {
    this.service.GetObjectData().subscribe(res => {
      this.ObjectList = res as any[];
    }, error => {
      console.log(error);

    })
  }

  GetDataField() {
    this.service.GetDataField().subscribe(res => {
     
      this.DataFieldList = res as any[];
    }, error => {
      console.log(error);
    })
  }

  Submit() {this.service.GetReadingData(this.readingSearchForm.controls['buildingId'].value, this.readingSearchForm.controls['objectId'].value, this.readingSearchForm.controls['dataId'].value, new Date(this.readingSearchForm.controls['fDate'].value), new Date(this.readingSearchForm.controls['tDate'].value))
      .subscribe(readDataList => {
        this.readDataList = readDataList as any[];
        
        let i = 0;
        let j = 0;
        this.valueData=[];
        this.labelData=[];
        for (i = 0; i < this.readDataList.length; i++) {
        
          this.labelData.push(this.readDataList[i].name);
          this.valueData.push(this.readDataList[i].count);
        }
       
        this.data=[];
      
        this.data = {
       
          labels: this.labelData,
          
  
          datasets: [{
            label:"",
           minRange:0,
            data: this.valueData,
            
            fill:false,
            backgroundColor: 'brown',
            borderColor: 'brown',
            lineTension: 1,
            
                  borderWidth: 1.5
                  
                 
          }]
        }
     
    
      });
  }
}


