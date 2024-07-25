using Accountbank.Domain.Models;
using Accountbank.Shared.Interfaces;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Accountbank.Shared.Utilities;

public class PdfGenerator : IPdfGenerator
{
	public byte[] GeneratePdf(List<Transaction> transactions)
	{
		using var stream = new MemoryStream();
		var writer = new PdfWriter(stream);
		var pdf = new PdfDocument(writer);
		var document = new Document(pdf);

		document.Add(new Paragraph("Extrato Bancário")
			.SetTextAlignment(TextAlignment.CENTER)
			.SetFontSize(20));

		var table = new Table(3, true);
		table.AddCell(new Cell().Add(new Paragraph("Data")));
		table.AddCell(new Cell().Add(new Paragraph("Tipo da Transação")));
		table.AddCell(new Cell().Add(new Paragraph("Valor Monetário")));

		foreach (var transaction in transactions)
		{
			table.AddCell(new Cell().Add(new Paragraph(transaction.Date.ToString("dd/MM/yyyy"))));
			table.AddCell(new Cell().Add(new Paragraph(transaction.TransactionType.ToString())));
			table.AddCell(new Cell().Add(new Paragraph(transaction.Amount.ToString("C"))));
		}

		document.Add(table);
		document.Close();

		return stream.ToArray();
	}
}
