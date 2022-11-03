package pantallas;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f4_generarReporte extends javax.swing.JFrame {

    public f4_generarReporte() {
        initComponents();
    }
    
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormGenerarReporte = new javax.swing.JPanel();
        etiquetaTipoDeReporte = new javax.swing.JLabel();
        seleccionadorDeTipoDeReporte = new javax.swing.JComboBox<>();
        botonGenerarReportePDF = new javax.swing.JButton();
        botonRegresarAPuntoDeVenta = new javax.swing.JButton();
        barraDeslizanteGR = new javax.swing.JScrollBar();
        tablaVentaDeArticulos = new javax.swing.JScrollPane();
        tablaDeVentas = new javax.swing.JTable();
        fondoDelFormPDV = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("GENERAR REPORTE");

        contenedorFormGenerarReporte.setBackground(new java.awt.Color(102, 204, 255));
        contenedorFormGenerarReporte.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaTipoDeReporte.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaTipoDeReporte.setText("TIPO DE REPORTE:");
        contenedorFormGenerarReporte.add(etiquetaTipoDeReporte, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 150, 100, 20));

        seleccionadorDeTipoDeReporte.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "---" }));
        contenedorFormGenerarReporte.add(seleccionadorDeTipoDeReporte, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 150, 670, -1));

        botonGenerarReportePDF.setBackground(new java.awt.Color(74, 96, 106));
        botonGenerarReportePDF.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonGenerarReportePDF.setForeground(new java.awt.Color(255, 255, 255));
        botonGenerarReportePDF.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGenerarPDF_GR_1.png"))); // NOI18N
        botonGenerarReportePDF.setText("GENERAR PDF");
        contenedorFormGenerarReporte.add(botonGenerarReportePDF, new org.netbeans.lib.awtextra.AbsoluteConstraints(737, 410, -1, 50));

        botonRegresarAPuntoDeVenta.setBackground(new java.awt.Color(74, 96, 106));
        botonRegresarAPuntoDeVenta.setFont(new java.awt.Font("Cambria", 0, 30)); // NOI18N
        botonRegresarAPuntoDeVenta.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAPuntoDeVenta.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBotonRegresarAPuntoDeVenta_GR_2.png"))); // NOI18N
        botonRegresarAPuntoDeVenta.setText("     REGRESAR A PUNTO DE VENTA");
        contenedorFormGenerarReporte.add(botonRegresarAPuntoDeVenta, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 490, 550, 70));
        contenedorFormGenerarReporte.add(barraDeslizanteGR, new org.netbeans.lib.awtextra.AbsoluteConstraints(860, 210, -1, 180));

        tablaDeVentas.setAutoCreateRowSorter(true);
        tablaDeVentas.setBackground(new java.awt.Color(204, 204, 255));
        tablaDeVentas.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        tablaDeVentas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "FECHA", "PRODUCTOS", "CANTIDAD", "VENTA"
            }
        ));
        tablaDeVentas.setToolTipText("");
        tablaVentaDeArticulos.setViewportView(tablaDeVentas);

        contenedorFormGenerarReporte.add(tablaVentaDeArticulos, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 180, 780, 220));

        fondoDelFormPDV.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/4_fondoPantallaGenerarReporte.jpeg"))); // NOI18N
        fondoDelFormPDV.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        contenedorFormGenerarReporte.add(fondoDelFormPDV, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1020, 580));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGenerarReporte, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGenerarReporte, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f4_generarReporte.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new f4_generarReporte().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JScrollBar barraDeslizanteGR;
    private javax.swing.JButton botonGenerarReportePDF;
    private javax.swing.JButton botonRegresarAPuntoDeVenta;
    private javax.swing.JPanel contenedorFormGenerarReporte;
    private javax.swing.JLabel etiquetaTipoDeReporte;
    private javax.swing.JLabel fondoDelFormPDV;
    private javax.swing.JComboBox<String> seleccionadorDeTipoDeReporte;
    private javax.swing.JTable tablaDeVentas;
    private javax.swing.JScrollPane tablaVentaDeArticulos;
    // End of variables declaration//GEN-END:variables
}
