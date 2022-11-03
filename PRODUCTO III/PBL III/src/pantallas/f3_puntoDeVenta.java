package pantallas;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f3_puntoDeVenta extends javax.swing.JFrame {

    public f3_puntoDeVenta() {
        initComponents();
    }
    
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormPuntoDeVenta = new javax.swing.JPanel();
        etiquetaBusquedaPor = new javax.swing.JLabel();
        filtroDeBusqueda = new javax.swing.JComboBox<>();
        valorBusqueda = new javax.swing.JTextField();
        botonBusquedaArticuloPV = new javax.swing.JButton();
        barraDeslizantePV = new javax.swing.JScrollBar();
        tablaVentaDeArticulos = new javax.swing.JScrollPane();
        tablaDeVentas = new javax.swing.JTable();
        botonGenerarReporte = new javax.swing.JButton();
        botonGenerarVenta = new javax.swing.JButton();
        botonEliminar = new javax.swing.JButton();
        botonRegresarAMenu = new javax.swing.JButton();
        fondoDelFormPDV = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("PUNTO DE VENTA");

        contenedorFormPuntoDeVenta.setBackground(new java.awt.Color(255, 255, 255));
        contenedorFormPuntoDeVenta.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaBusquedaPor.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaBusquedaPor.setText("BUSCAR POR:");
        contenedorFormPuntoDeVenta.add(etiquetaBusquedaPor, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 150, 70, 20));

        filtroDeBusqueda.setBackground(new java.awt.Color(147, 175, 197));
        filtroDeBusqueda.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        filtroDeBusqueda.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "ID_ARTICULO", "NOMBRE_ARTICULO", "PRECIO_ARTICULO", " " }));
        filtroDeBusqueda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                filtroDeBusquedaActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(filtroDeBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 150, 170, -1));
        contenedorFormPuntoDeVenta.add(valorBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 150, 330, -1));

        botonBusquedaArticuloPV.setBackground(new java.awt.Color(74, 96, 106));
        botonBusquedaArticuloPV.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBusquedaArticuloPV.setForeground(new java.awt.Color(255, 255, 255));
        botonBusquedaArticuloPV.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBusquedaDeProducto_PDV_1.png"))); // NOI18N
        botonBusquedaArticuloPV.setText("BUSCAR ARTÍCULO");
        contenedorFormPuntoDeVenta.add(botonBusquedaArticuloPV, new org.netbeans.lib.awtextra.AbsoluteConstraints(710, 130, 170, -1));
        contenedorFormPuntoDeVenta.add(barraDeslizantePV, new org.netbeans.lib.awtextra.AbsoluteConstraints(860, 210, -1, 180));

        tablaDeVentas.setAutoCreateRowSorter(true);
        tablaDeVentas.setBackground(new java.awt.Color(204, 204, 255));
        tablaDeVentas.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        tablaDeVentas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "ID_ARTICULO", "NOMBRE_ARTICULO", "PRECIO_ARTICULO", "CANTIDAD_A_VENDER"
            }
        ));
        tablaVentaDeArticulos.setViewportView(tablaDeVentas);

        contenedorFormPuntoDeVenta.add(tablaVentaDeArticulos, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 180, 780, 220));

        botonGenerarReporte.setBackground(new java.awt.Color(74, 96, 106));
        botonGenerarReporte.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonGenerarReporte.setForeground(new java.awt.Color(255, 255, 255));
        botonGenerarReporte.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGenerarReportePuntoDeVenta_2.png"))); // NOI18N
        botonGenerarReporte.setText("GENERAR REPORTE");
        contenedorFormPuntoDeVenta.add(botonGenerarReporte, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 410, 170, -1));

        botonGenerarVenta.setBackground(new java.awt.Color(74, 96, 106));
        botonGenerarVenta.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonGenerarVenta.setForeground(new java.awt.Color(255, 255, 255));
        botonGenerarVenta.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoGenerarVentaPuntoDeVenta_3.png"))); // NOI18N
        botonGenerarVenta.setText("GENERAR VENTA");
        botonGenerarVenta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonGenerarVentaActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(botonGenerarVenta, new org.netbeans.lib.awtextra.AbsoluteConstraints(550, 410, 160, -1));

        botonEliminar.setBackground(new java.awt.Color(74, 96, 106));
        botonEliminar.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonEliminar.setForeground(new java.awt.Color(255, 255, 255));
        botonEliminar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoEliminarPuntoDeVenta_4.png"))); // NOI18N
        botonEliminar.setText("ELIMINAR");
        contenedorFormPuntoDeVenta.add(botonEliminar, new org.netbeans.lib.awtextra.AbsoluteConstraints(720, 410, 160, -1));

        botonRegresarAMenu.setBackground(new java.awt.Color(74, 96, 106));
        botonRegresarAMenu.setFont(new java.awt.Font("Cambria", 0, 30)); // NOI18N
        botonRegresarAMenu.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAMenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/iconoBotonRegresarAMenu_PDV_5.png"))); // NOI18N
        botonRegresarAMenu.setText("REGRESAR A MENÚ");
        contenedorFormPuntoDeVenta.add(botonRegresarAMenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 490, 360, 70));

        fondoDelFormPDV.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/3_fondoPantallaPuntoDeVenta.jpeg"))); // NOI18N
        fondoDelFormPDV.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        contenedorFormPuntoDeVenta.add(fondoDelFormPDV, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 580));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormPuntoDeVenta, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormPuntoDeVenta, javax.swing.GroupLayout.PREFERRED_SIZE, 580, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void filtroDeBusquedaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_filtroDeBusquedaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_filtroDeBusquedaActionPerformed

    private void botonGenerarVentaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonGenerarVentaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonGenerarVentaActionPerformed
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
            java.util.logging.Logger.getLogger(f3_puntoDeVenta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f3_puntoDeVenta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f3_puntoDeVenta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f3_puntoDeVenta.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new f3_puntoDeVenta().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JScrollBar barraDeslizantePV;
    private javax.swing.JButton botonBusquedaArticuloPV;
    private javax.swing.JButton botonEliminar;
    private javax.swing.JButton botonGenerarReporte;
    private javax.swing.JButton botonGenerarVenta;
    private javax.swing.JButton botonRegresarAMenu;
    private javax.swing.JPanel contenedorFormPuntoDeVenta;
    private javax.swing.JLabel etiquetaBusquedaPor;
    private javax.swing.JComboBox<String> filtroDeBusqueda;
    private javax.swing.JLabel fondoDelFormPDV;
    private javax.swing.JTable tablaDeVentas;
    private javax.swing.JScrollPane tablaVentaDeArticulos;
    private javax.swing.JTextField valorBusqueda;
    // End of variables declaration//GEN-END:variables
}
