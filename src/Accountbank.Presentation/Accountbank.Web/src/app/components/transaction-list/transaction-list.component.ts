import { Component, OnInit } from '@angular/core';
import { TransactionService } from '../../services/transaction.service';

@Component({
  selector: 'app-transaction-list',
  templateUrl: './transaction-list.component.html',
  styleUrls: ['./transaction-list.component.css']
})
export class TransactionListComponent implements OnInit {
  transactions: any[] = [];
  daysOptions: number[] = [5, 10, 15, 20];
  selectedDays = 5;
  displayedColumns: string[] = ['date', 'transactionType', 'amount'];

  constructor(private transactionService: TransactionService) { }

  ngOnInit(): void {
    this.loadTransactions();
  }

  onDaysChange(): void {
    this.loadTransactions();
  }

  loadTransactions(): void {
    this.transactionService.getTransactions(this.selectedDays)
      .subscribe(data => {
        this.transactions = data;
      });
  }
}
