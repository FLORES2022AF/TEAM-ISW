package pantallas;

import conexion.Conexion;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.time.Instant;
import java.util.Date;
import java.util.Vector;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import static pantallas.f1_login.rol;
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
        CD();
    }
    int rol = f1_login.rol;
    int precioT = 0;
    Conexion baseDatos = new Conexion().conectar();
    DefaultTableModel modelo = new DefaultTableModel();
        
    
    public void CD(){
        this.TABLAV.setModel(modelo);
        modelo.addColumn("ID PRODUCTO");
        modelo.addColumn("NOMBRE");
        modelo.addColumn("Cantidad");
        modelo.addColumn("PRECIO");
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTextField1 = new javax.swing.JTextField();
        contenedorFormPuntoDeVenta = new javax.swing.JPanel();
        etiquetaBusquedaPor = new javax.swing.JLabel();
        TV = new javax.swing.JLabel();
        ID_PRODUCTO = new javax.swing.JTextField();
        CANTIDAD = new javax.swing.JTextField();
        tablaVentaDeArticulos = new javax.swing.JScrollPane();
        TABLAV = new javax.swing.JTable();
        botonBusquedaArticuloPV = new javax.swing.JButton();
        botonGenerarReporte = new javax.swing.JButton();
        botonGenerarVenta = new javax.swing.JButton();
        botonEliminar = new javax.swing.JButton();
        botonRegresarAMenu = new javax.swing.JButton();
        fondoPDV = new javax.swing.JLabel();

        jTextField1.setText("jTextField1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("PUNTO DE VENTA");
        setMinimumSize(new java.awt.Dimension(1000, 500));

        contenedorFormPuntoDeVenta.setBackground(new java.awt.Color(255, 255, 255));
        contenedorFormPuntoDeVenta.setMinimumSize(new java.awt.Dimension(1000, 500));
        contenedorFormPuntoDeVenta.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormPuntoDeVenta.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaBusquedaPor.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaBusquedaPor.setText("INGRESA EL ID DEL PRODUCTO");
        contenedorFormPuntoDeVenta.add(etiquetaBusquedaPor, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 150, 170, 20));

        TV.setText("TOTAL DE VENTA:");
        contenedorFormPuntoDeVenta.add(TV, new org.netbeans.lib.awtextra.AbsoluteConstraints(670, 360, 170, -1));

        ID_PRODUCTO.setText("ID");
        ID_PRODUCTO.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ID_PRODUCTOActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(ID_PRODUCTO, new org.netbeans.lib.awtextra.AbsoluteConstraints(280, 150, 80, -1));

        CANTIDAD.setText("CANTIDAD");
        CANTIDAD.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                CANTIDADActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(CANTIDAD, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 150, 120, -1));

        TABLAV.setAutoCreateRowSorter(true);
        TABLAV.setBackground(new java.awt.Color(204, 204, 255));
        TABLAV.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        TABLAV.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        tablaVentaDeArticulos.setViewportView(TABLAV);

        contenedorFormPuntoDeVenta.add(tablaVentaDeArticulos, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 180, 780, 170));

        botonBusquedaArticuloPV.setBackground(new java.awt.Color(69, 100, 123));
        botonBusquedaArticuloPV.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBusquedaArticuloPV.setForeground(new java.awt.Color(255, 255, 255));
        botonBusquedaArticuloPV.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/M)iconoBusquedaDeProducto(INGRESAR-BUSCAR)_PDV_1.png"))); // NOI18N
        botonBusquedaArticuloPV.setText("INGRESAR / BUSCAR");
        botonBusquedaArticuloPV.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonBusquedaArticuloPVActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(botonBusquedaArticuloPV, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 130, 180, -1));

        botonGenerarReporte.setBackground(new java.awt.Color(69, 100, 123));
        botonGenerarReporte.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonGenerarReporte.setForeground(new java.awt.Color(255, 255, 255));
        botonGenerarReporte.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/N)iconoGenerarReporte_PDV_2.png"))); // NOI18N
        botonGenerarReporte.setText("GENERAR REPORTE");
        botonGenerarReporte.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonGenerarReporteActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(botonGenerarReporte, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 380, 170, -1));

        botonGenerarVenta.setBackground(new java.awt.Color(69, 100, 123));
        botonGenerarVenta.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonGenerarVenta.setForeground(new java.awt.Color(255, 255, 255));
        botonGenerarVenta.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/O)iconoGenerarVenta_PDV_3.png"))); // NOI18N
        botonGenerarVenta.setText("GENERAR VENTA");
        botonGenerarVenta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonGenerarVentaActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(botonGenerarVenta, new org.netbeans.lib.awtextra.AbsoluteConstraints(550, 380, 160, -1));

        botonEliminar.setBackground(new java.awt.Color(69, 100, 123));
        botonEliminar.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonEliminar.setForeground(new java.awt.Color(255, 255, 255));
        botonEliminar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/P)iconoEliminarPuntoDeVenta_4.png"))); // NOI18N
        botonEliminar.setText("ELIMINAR");
        botonEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonEliminarActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(botonEliminar, new org.netbeans.lib.awtextra.AbsoluteConstraints(720, 380, 160, -1));

        botonRegresarAMenu.setBackground(new java.awt.Color(40, 64, 72));
        botonRegresarAMenu.setFont(new java.awt.Font("Cambria", 0, 18)); // NOI18N
        botonRegresarAMenu.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAMenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/Q)iconoBotonRegresarAMenu_PDV_5.png"))); // NOI18N
        botonRegresarAMenu.setText("REGRESAR A MENÚ");
        botonRegresarAMenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonRegresarAMenuActionPerformed(evt);
            }
        });
        contenedorFormPuntoDeVenta.add(botonRegresarAMenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 450, 220, 40));

        fondoPDV.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/4)fondoPantallaPuntoDeVenta.jpeg"))); // NOI18N
        fondoPDV.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        fondoPDV.setMaximumSize(new java.awt.Dimension(1000, 500));
        fondoPDV.setMinimumSize(new java.awt.Dimension(1000, 500));
        fondoPDV.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormPuntoDeVenta.add(fondoPDV, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 500));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormPuntoDeVenta, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormPuntoDeVenta, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

 
    private void botonGenerarVentaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonGenerarVentaActionPerformed
        // TODO add your handling code here:
         SimpleDateFormat Formato2 = new SimpleDateFormat("dd-MM-yy");                                          
        Date date = Date.from(Instant.now());
        String Fecha = Formato2.format(date);
        
        
        int can = 0, can2 = 0;
        int idv = 1;
        boolean sentencia;
        for(int i = modelo.getRowCount() - 1; i>=0; i --){
            String id = modelo.getValueAt(i, 0).toString();
            String cantidad = modelo.getValueAt(i,2).toString();
            can = Integer.parseInt(cantidad);
            ResultSet rs= baseDatos.consultar("SELECT CANTIDAD FROM PRODUCTOS WHERE ID_PRODUCTO = "+ id);
            
            try{
                if(rs.next()){
                    can2= rs.getInt(1) - can;
                }
            }catch(Exception e){
                
            }
            
            sentencia = baseDatos.ejecutar("Update Productos Set cantidad = '"+ can2+ "' where id_producto = " + id);
            modelo.removeRow(i);
            
            ResultSet rs2 = baseDatos.consultar("SELECT MAX(ID_VENTAS) FROM VENTAS");
        
        try{
            if(rs2.next()){
                idv = rs2.getInt(1);
                idv++;
            }
      
        }catch(Exception e){
            
        }
        
        boolean sentencia2;
        sentencia2 = baseDatos.ejecutar("INSERT INTO VENTAS VALUES('"+idv+"', '"+id+"', '" +can+ "', '"+Fecha+"')");
        
            JOptionPane.showMessageDialog(null,"Venta generada",null, JOptionPane.INFORMATION_MESSAGE);
            
            
        }
        
        
        
        
        
    }//GEN-LAST:event_botonGenerarVentaActionPerformed

    private void botonRegresarAMenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonRegresarAMenuActionPerformed
        if(rol == 1){
                    new f2_menuDueno().setVisible(true);
                   dispose();
                }else{
                    new f2_menuEncargado().setVisible(true);
                   dispose();
                }
    }//GEN-LAST:event_botonRegresarAMenuActionPerformed

    private void CANTIDADActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_CANTIDADActionPerformed
        // TODO add your handling code here:            
        
    }//GEN-LAST:event_CANTIDADActionPerformed

    private void ID_PRODUCTOActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ID_PRODUCTOActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_ID_PRODUCTOActionPerformed

    private void botonBusquedaArticuloPVActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonBusquedaArticuloPVActionPerformed
        // TODO add your handling code here:
        this.TABLAV.setModel(modelo);
        String producto = ID_PRODUCTO.getText();
        String cantidad = CANTIDAD.getText();
        int precio =0;
        
        ResultSet rs = baseDatos.consultar("SELECT * FROM PRODUCTOS WHERE ID_PRODUCTO = "+ producto );
      
        try{
            while(rs.next()){
                Vector v = new Vector();
                v.add(rs.getString(1));
                v.add(rs.getString(2));
                v.add(cantidad);
                precio = rs.getInt("PRECIO");
                precio = precio * Integer.parseInt(cantidad);
                v.add(precio);        
                modelo.addRow(v);        
            }

            

        }catch(Exception e){
            
        }
        
        
        precioT = precioT + precio;                
        TV.setText(String.valueOf("TOTAL DE VENTA: " + precioT));
        
        
    }//GEN-LAST:event_botonBusquedaArticuloPVActionPerformed

    private void botonEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonEliminarActionPerformed
        // TODO add your handling code here:
        int i = modelo.getRowCount();
        modelo.removeRow(i-1);
        

    }//GEN-LAST:event_botonEliminarActionPerformed

    private void botonGenerarReporteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonGenerarReporteActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_botonGenerarReporteActionPerformed
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
    private javax.swing.JTextField CANTIDAD;
    private javax.swing.JTextField ID_PRODUCTO;
    private javax.swing.JTable TABLAV;
    private javax.swing.JLabel TV;
    private javax.swing.JButton botonBusquedaArticuloPV;
    private javax.swing.JButton botonEliminar;
    private javax.swing.JButton botonGenerarReporte;
    private javax.swing.JButton botonGenerarVenta;
    private javax.swing.JButton botonRegresarAMenu;
    private javax.swing.JPanel contenedorFormPuntoDeVenta;
    private javax.swing.JLabel etiquetaBusquedaPor;
    private javax.swing.JLabel fondoPDV;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JScrollPane tablaVentaDeArticulos;
    // End of variables declaration//GEN-END:variables

}

