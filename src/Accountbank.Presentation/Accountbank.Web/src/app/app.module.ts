import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { MatTableModule } from '@angular/material/table';
import { MatSelectModule } from '@angular/material/select';
import { MatButtonModule } from '@angular/material/button';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

import { TransactionListComponent } from './components/transaction-list/transaction-list.component';
import { ExportButtonComponent } from './components/export-button/export-button.component';
import { TransactionService } from './services/transaction.service';
import { PdfService } from './services/pdf.service';


@NgModule({
  declarations: [
    AppComponent,
    TransactionListComponent,
    ExportButtonComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatTableModule,
    MatSelectModule,
    MatButtonModule
  ],
  providers: [
    provideAnimationsAsync(),
    TransactionService, PdfService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
