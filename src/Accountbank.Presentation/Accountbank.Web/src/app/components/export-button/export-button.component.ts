import { Component, Input } from '@angular/core';
import { PdfService } from '../../services/pdf.service';

@Component({
  selector: 'app-export-button',
  template: `
    <button (click)="exportPdf()">Exportar para PDF</button>
  `
})
export class ExportButtonComponent {
  @Input() days!: number;

  constructor(private pdfService: PdfService) {}

  exportPdf(): void {
    this.pdfService.generatePdf(this.days);
  }
}
