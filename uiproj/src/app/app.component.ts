import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListBoxService } from './services/list-box.service';
import { ListBox } from './model/ListBox.model';
import { MultiSelectModule } from 'primeng/multiselect';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    MultiSelectModule,
    CommonModule,
    HttpClientModule,
    FormsModule,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  constructor(private apiService: ListBoxService) {}
  data: ListBox[] = [];
  selectedItemsA: any[] = [];
  selectedItemsB: any[] = [];
  selectedItemsC: any[] = [];
  ngOnInit() {
    this.apiService.getItems().subscribe(
      (response) => {
        this.data = response;
      },
      (error) => {
        console.error('Error fetching data:', error);
      }
    );
    //this.selectedItems = [{ item }];
  }
  title = 'uiproj';
  onChangeA(event: any): void {
    console.log(event.value);

    this.selectedItemsB = [];
    this.selectedItemsC = [];
  }
  onChangeB(event: any): void {
    this.selectedItemsA = [];
    this.selectedItemsC = [];
  }
  onChangeC(event: any): void {
    this.selectedItemsA = [];
    this.selectedItemsB = [];
  }
}
