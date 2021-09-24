import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { DatePipe } from '@angular/common'
@Injectable({
  providedIn: 'root'
})
export class ReadingserviceService {
  baseUrl = environment.apiIurl + "//Building​//GetBuildingList";
  baseUrl_ = this.baseUrl.replace(/[?&]$/, "");



  constructor(private http: HttpClient, public datepipe:DatePipe) { }



  getBuildingData(): Observable<any> {
    return this.http.get<any[]>("http://localhost:13764/api/Building", {
    });
  }
  GetObjectData(): Observable<any> {
    return this.http.get<any[]>("http://localhost:13764/api/Object", {
    });

  }
  GetDataField(): Observable<any> {
    return this.http.get<any[]>("http://localhost:13764/api/DataField", {
    });

  }

  GetReadingData(buildingId:number,ObjectId:number,dataId:number,fData:Date,tDate:Date): Observable<any>{
    console.log(fData);
    const datePipe = new DatePipe('en-US');
    
    var fd = datePipe.transform(fData, 'yyyy-MM-dd');
    var td = datePipe.transform(tDate, 'yyyy-MM-dd');
      
    return this.http.get<any[]>("http://localhost:13764/api/Reading/GetReadingList?buildingId="+Number(buildingId)+"&objectId="+Number(ObjectId)+"&dataFieldId="+Number(dataId)+"&startTime="+fd+"&endTime="+td, {
    });
  }

  GetReadingAllData(): Observable<any>{
    return this.http.get<any[]>("http://localhost:13764/api/Reading", {
    });
  }
}
