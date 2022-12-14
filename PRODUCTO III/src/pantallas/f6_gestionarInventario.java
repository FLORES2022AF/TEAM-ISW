package pantallas;

import conexion.Conexion;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f6_gestionarInventario extends javax.swing.JFrame {

    public f6_gestionarInventario() {
        initComponents();
        setLocationRelativeTo(null);
        botonModificarArticulo.setEnabled(false);
        botonBusquedaArticuloGI.setEnabled(false);
        botonBorrarArticulo.setEnabled(false);
        botonDarDeAltaArticulo.setEnabled(false);
    }
    public void validarAgregar(){
        if(campoID.getText().isEmpty() || campoNombreArticulo.getText().isEmpty() ||
                descripcion.getText().isEmpty() ||campoPrecioArticulo.getText().isEmpty() ||
                campoCantidadActual.getText().isEmpty() || campoCantidadSeguridad.getText().isEmpty()){
            botonDarDeAltaArticulo.setEnabled(false);
        }else{
            botonDarDeAltaArticulo.setEnabled(true);
        }
    }
    public void validarBorrar(){
        if(campoID.getText().isEmpty()){
            botonBorrarArticulo.setEnabled(false);
        } else{
            botonBorrarArticulo.setEnabled(true);
        }
    }
    public void validarBuscar(){
        if(valorBusqueda.getText().isEmpty()){
            botonBusquedaArticuloGI.setEnabled(false);
        }else{
            botonBusquedaArticuloGI.setEnabled(true);
        }
    }
    public void validarModificar(){
        if(campoID.getText().isEmpty()){
            lblid.setText("*Agregar campo");
        }else{
            lblid.setText("");
        }
        if(campoNombreArticulo.getText().isEmpty()){
            lblarticulo.setText("*Agregar campo");
        }else{
            lblarticulo.setText("");
        }
        if(descripcion.getText().isEmpty()){
            lbldescripcion.setText("*Agregar campo");
        }else{
            lbldescripcion.setText("");
        }
        if(campoPrecioArticulo.getText().isEmpty()){
            lblprecio.setText("*Agregar campo");
        }else{
            lblprecio.setText("");
        }
        if(campoCantidadActual.getText().isEmpty()){
            lblactual.setText("*Agregar campo");
        }else{
            lblactual.setText("");
        }
        if(campoCantidadSeguridad.getText().isEmpty()){
            lblseguridad.setText("*Agregar campo");
        }else{
            lblseguridad.setText("");
        }
        if(campoID.getText().isEmpty() || campoNombreArticulo.getText().isEmpty() ||
                descripcion.getText().isEmpty() ||campoPrecioArticulo.getText().isEmpty() ||
                campoCantidadActual.getText().isEmpty() || campoCantidadSeguridad.getText().isEmpty()){
            botonModificarArticulo.setEnabled(false);
        }else{
            botonModificarArticulo.setEnabled(true);
        }
       
    }
    
        Conexion baseDatos = new Conexion().conectar();
     int rol = f1_login.rol;
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormGestionarInventario = new javax.swing.JPanel();
        etiquetaBusquedaPor = new javax.swing.JLabel();
        lblid = new javax.swing.JLabel();
        lblarticulo = new javax.swing.JLabel();
        lbldescripcion = new javax.swing.JLabel();
        lblprecio = new javax.swing.JLabel();
        lblactual = new javax.swing.JLabel();
        lblseguridad = new javax.swing.JLabel();
        filtroDeBusqueda = new javax.swing.JComboBox<>();
        valorBusqueda = new javax.swing.JTextField();
        campoID = new javax.swing.JTextField();
        campoNombreArticulo = new javax.swing.JTextField();
        campoPrecioArticulo = new javax.swing.JTextField();
        campoCantidadSeguridad = new javax.swing.JTextField();
        campoCantidadActual = new javax.swing.JTextField();
        descripcion = new javax.swing.JTextField();
        tablaInventarioDeArticulos = new javax.swing.JScrollPane();
        tablaDeInventario = new javax.swing.JTable();
        botonBusquedaArticuloGI = new javax.swing.JButton();
        botonBorrarArticulo = new javax.swing.JButton();
        botonModificarArticulo = new javax.swing.JButton();
        botonDarDeAltaArticulo = new javax.swing.JButton();
        botonRegresarAMenu = new javax.swing.JButton();
        fondoGI = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("GESTIONAR INVENTARIO");

        contenedorFormGestionarInventario.setBackground(new java.awt.Color(255, 255, 255));
        contenedorFormGestionarInventario.setMinimumSize(new java.awt.Dimension(1000, 500));
        contenedorFormGestionarInventario.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGestionarInventario.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaBusquedaPor.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaBusquedaPor.setText("BUSCAR POR:");
        contenedorFormGestionarInventario.add(etiquetaBusquedaPor, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 150, 70, 20));

        lblid.setFont(new java.awt.Font("Arial", 2, 11)); // NOI18N
        lblid.setForeground(new java.awt.Color(255, 0, 0));
        contenedorFormGestionarInventario.add(lblid, new org.netbeans.lib.awtextra.AbsoluteConstraints(90, 180, 60, -1));

        lblarticulo.setFont(new java.awt.Font("Arial", 0, 11)); // NOI18N
        lblarticulo.setForeground(new java.awt.Color(255, 0, 51));
        contenedorFormGestionarInventario.add(lblarticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 180, -1, -1));

        lbldescripcion.setFont(new java.awt.Font("Arial", 0, 11)); // NOI18N
        lbldescripcion.setForeground(new java.awt.Color(255, 0, 0));
        contenedorFormGestionarInventario.add(lbldescripcion, new org.netbeans.lib.awtextra.AbsoluteConstraints(390, 180, -1, -1));

        lblprecio.setFont(new java.awt.Font("Arial", 0, 11)); // NOI18N
        lblprecio.setForeground(new java.awt.Color(255, 51, 51));
        contenedorFormGestionarInventario.add(lblprecio, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 180, -1, -1));

        lblactual.setFont(new java.awt.Font("Arial", 0, 11)); // NOI18N
        lblactual.setForeground(new java.awt.Color(255, 0, 0));
        contenedorFormGestionarInventario.add(lblactual, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 180, -1, -1));

        lblseguridad.setFont(new java.awt.Font("Arial", 0, 11)); // NOI18N
        lblseguridad.setForeground(new java.awt.Color(255, 0, 0));
        contenedorFormGestionarInventario.add(lblseguridad, new org.netbeans.lib.awtextra.AbsoluteConstraints(840, 180, -1, -1));

        filtroDeBusqueda.setBackground(new java.awt.Color(147, 175, 197));
        filtroDeBusqueda.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        filtroDeBusqueda.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "ID_ARTICULO", "NOMBRE_ARTICULO", "PRECIO_ARTICULO", " " }));
        filtroDeBusqueda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                filtroDeBusquedaActionPerformed(evt);
            }
        });
        contenedorFormGestionarInventario.add(filtroDeBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 150, 170, -1));

        valorBusqueda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                valorBusquedaActionPerformed(evt);
            }
        });
        valorBusqueda.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                valorBusquedaKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                valorBusquedaKeyTyped(evt);
            }
        });
        contenedorFormGestionarInventario.add(valorBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(330, 150, 390, -1));

        campoID.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoID.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                campoIDActionPerformed(evt);
            }
        });
        campoID.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                campoIDKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                campoIDKeyTyped(evt);
            }
        });
        contenedorFormGestionarInventario.add(campoID, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 200, 80, -1));

        campoNombreArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoNombreArticulo.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                campoNombreArticuloKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                campoNombreArticuloKeyTyped(evt);
            }
        });
        contenedorFormGestionarInventario.add(campoNombreArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 200, 130, -1));

        campoPrecioArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoPrecioArticulo.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                campoPrecioArticuloKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                campoPrecioArticuloKeyTyped(evt);
            }
        });
        contenedorFormGestionarInventario.add(campoPrecioArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(590, 200, 70, -1));

        campoCantidadSeguridad.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoCantidadSeguridad.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                campoCantidadSeguridadKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                campoCantidadSeguridadKeyTyped(evt);
            }
        });
        contenedorFormGestionarInventario.add(campoCantidadSeguridad, new org.netbeans.lib.awtextra.AbsoluteConstraints(840, 200, 60, -1));

        campoCantidadActual.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        campoCantidadActual.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                campoCantidadActualKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                campoCantidadActualKeyTyped(evt);
            }
        });
        contenedorFormGestionarInventario.add(campoCantidadActual, new org.netbeans.lib.awtextra.AbsoluteConstraints(720, 200, 60, -1));

        descripcion.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                descripcionActionPerformed(evt);
            }
        });
        descripcion.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                descripcionKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                descripcionKeyTyped(evt);
            }
        });
        contenedorFormGestionarInventario.add(descripcion, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 200, 180, -1));

        tablaDeInventario.setAutoCreateRowSorter(true);
        tablaDeInventario.setBackground(new java.awt.Color(204, 204, 255));
        tablaDeInventario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        tablaDeInventario.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        tablaInventarioDeArticulos.setViewportView(tablaDeInventario);

        contenedorFormGestionarInventario.add(tablaInventarioDeArticulos, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 230, 860, 190));

        botonBusquedaArticuloGI.setBackground(new java.awt.Color(74, 96, 106));
        botonBusquedaArticuloGI.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBusquedaArticuloGI.setForeground(new java.awt.Color(255, 255, 255));
        botonBusquedaArticuloGI.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/ZA)iconoBusquedaDeArticulo_GI_1.png"))); // NOI18N
        botonBusquedaArticuloGI.setText("BUSCAR ARTÍCULO");
        botonBusquedaArticuloGI.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonBusquedaArticuloGIActionPerformed(evt);
            }
        });
        contenedorFormGestionarInventario.add(botonBusquedaArticuloGI, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 130, 170, -1));

        botonBorrarArticulo.setBackground(new java.awt.Color(74, 96, 106));
        botonBorrarArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBorrarArticulo.setForeground(new java.awt.Color(255, 255, 255));
        botonBorrarArticulo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/ZD)iconoBorrarArticuloGestionarInventario_4.png"))); // NOI18N
        botonBorrarArticulo.setText("BORRAR ARTÍCULO");
        botonBorrarArticulo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonBorrarArticuloActionPerformed(evt);
            }
        });
        botonBorrarArticulo.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                botonBorrarArticuloKeyPressed(evt);
            }
            public void keyReleased(java.awt.event.KeyEvent evt) {
                botonBorrarArticuloKeyReleased(evt);
            }
        });
        contenedorFormGestionarInventario.add(botonBorrarArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(760, 430, 170, -1));

        botonModificarArticulo.setBackground(new java.awt.Color(74, 96, 106));
        botonModificarArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonModificarArticulo.setForeground(new java.awt.Color(255, 255, 255));
        botonModificarArticulo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/ZC)iconoModificarArticuloGestionarInventario_3.png"))); // NOI18N
        botonModificarArticulo.setText("MODIFICAR ARTÍCULO");
        botonModificarArticulo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonModificarArticuloActionPerformed(evt);
            }
        });
        contenedorFormGestionarInventario.add(botonModificarArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(560, 430, 190, -1));

        botonDarDeAltaArticulo.setBackground(new java.awt.Color(74, 96, 106));
        botonDarDeAltaArticulo.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonDarDeAltaArticulo.setForeground(new java.awt.Color(255, 255, 255));
        botonDarDeAltaArticulo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/ZB)iconoDarDeAltaArticuloGestionarInventario_2.png"))); // NOI18N
        botonDarDeAltaArticulo.setText("DAR DE ALTA ARTÍCULO");
        botonDarDeAltaArticulo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonDarDeAltaArticuloActionPerformed(evt);
            }
        });
        contenedorFormGestionarInventario.add(botonDarDeAltaArticulo, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 430, 200, -1));

        botonRegresarAMenu.setBackground(new java.awt.Color(74, 96, 106));
        botonRegresarAMenu.setFont(new java.awt.Font("Cambria", 0, 18)); // NOI18N
        botonRegresarAMenu.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAMenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/ZE)iconoBotonRegresarAMenu_GI_5.png"))); // NOI18N
        botonRegresarAMenu.setText("REGRESAR A MENÚ");
        botonRegresarAMenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonRegresarAMenuActionPerformed(evt);
            }
        });
        contenedorFormGestionarInventario.add(botonRegresarAMenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 450, 230, 40));

        fondoGI.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/7)fondoPantallaGestionarInventario.jpeg"))); // NOI18N
        fondoGI.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        fondoGI.setMaximumSize(new java.awt.Dimension(1000, 500));
        fondoGI.setMinimumSize(new java.awt.Dimension(1000, 500));
        fondoGI.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGestionarInventario.add(fondoGI, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 530));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGestionarInventario, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(contenedorFormGestionarInventario, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void filtroDeBusquedaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_filtroDeBusquedaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_filtroDeBusquedaActionPerformed

    private void botonModificarArticuloActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonModificarArticuloActionPerformed
                
        boolean sentencia = false;
         sentencia= baseDatos.ejecutar("Update Productos Set nombre = '"+ campoNombreArticulo.getText()+"', precio = '"+ campoPrecioArticulo.getText()+"', cantidad = '"+campoCantidadSeguridad.getText()+"', cantidadR = '"+campoCantidadActual.getText()+"' WHERE ID_PRODUCTO = '"+campoID.getText()+"'" );
        JOptionPane.showMessageDialog(null,"Articulo modificado",null, JOptionPane.INFORMATION_MESSAGE);
       
    }//GEN-LAST:event_botonModificarArticuloActionPerformed

    private void botonRegresarAMenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonRegresarAMenuActionPerformed
        if(rol == 1){
                    new f2_menuDueno().setVisible(true);
                   dispose();
                }else{
                    new f2_menuEncargado().setVisible(true);
                   dispose();
                }
    }//GEN-LAST:event_botonRegresarAMenuActionPerformed

    private void botonBusquedaArticuloGIActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonBusquedaArticuloGIActionPerformed
        // TODO add your handling code here:
        
        int eleccion = filtroDeBusqueda.getSelectedIndex();
        if(eleccion == 0){
                        
            DefaultTableModel modelo = new DefaultTableModel();
        this.tablaDeInventario.setModel(modelo);
        ResultSet rs = baseDatos.consultar("SELECT * FROM productos where id_producto = "+valorBusqueda.getText()); 
            
        try {
            //Obteniendo la informacion de las columnas que estan siendo consultadas
            ResultSetMetaData rsMd = rs.getMetaData();
            //La cantidad de columnas que tiene la consulta
            int cantidadColumnas = rsMd.getColumnCount();
            //Establecer como cabezeras el nombre de las colimnas
            for (int i = 1; i <= cantidadColumnas; i++) {
             modelo.addColumn(rsMd.getColumnLabel(i));
            }
            //Creando las filas para el JTable
            while (rs.next()) {
             Object[] fila = new Object[cantidadColumnas];
             for (int i = 1; i <= cantidadColumnas; i++) {
               fila[i-1]=rs.getObject(i);               
               
             }
             modelo.addRow(fila);
            }
            rs.close();
            
       } catch (Exception ex) {
        ex.printStackTrace();
       }
            
            }else if(eleccion == 1){
            DefaultTableModel modelo = new DefaultTableModel();
        this.tablaDeInventario.setModel(modelo);
        ResultSet rs = baseDatos.consultar("SELECT * FROM productos where nombre like '"+valorBusqueda.getText()+ "%'"); 
            
        try {
            //Obteniendo la informacion de las columnas que estan siendo consultadas
            ResultSetMetaData rsMd = rs.getMetaData();
            //La cantidad de columnas que tiene la consulta
            int cantidadColumnas = rsMd.getColumnCount();
            //Establecer como cabezeras el nombre de las colimnas
            for (int i = 1; i <= cantidadColumnas; i++) {
             modelo.addColumn(rsMd.getColumnLabel(i));
            }
            //Creando las filas para el JTable
            while (rs.next()) {
             Object[] fila = new Object[cantidadColumnas];
             for (int i = 1; i <= cantidadColumnas; i++) {
               fila[i-1]=rs.getObject(i);               
               
             }
             modelo.addRow(fila);
            }
            rs.close();
            
       } catch (Exception ex) {
        ex.printStackTrace();
       }  
        }else{
            //mensaje de error seleccionar filtro
        }
        
    }//GEN-LAST:event_botonBusquedaArticuloGIActionPerformed

    private void botonDarDeAltaArticuloActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonDarDeAltaArticuloActionPerformed
        // TODO add your handling code here:
        
        boolean sentencia = false;
        sentencia = baseDatos.ejecutar("INSERT INTO PRODUCTOS VALUES ('"+campoID.getText()+"', '"+campoNombreArticulo.getText()+"', '"+descripcion.getText()+ "', '"+campoPrecioArticulo.getText() +"', '"+campoCantidadActual.getText()+"', '"+campoCantidadSeguridad.getText()+"')" );
        System.out.println("INSERT INTO PRODUCTOS VALUES ('"+campoID.getText()+"', '"+campoNombreArticulo.getText()+"', '"+descripcion.getText()+ "', '"+campoPrecioArticulo.getText() +"', '"+campoCantidadActual.getText()+"', '"+campoCantidadSeguridad.getText()+"')" );
        JOptionPane.showMessageDialog(null,"Articulo registrado",null, JOptionPane.INFORMATION_MESSAGE);
    }//GEN-LAST:event_botonDarDeAltaArticuloActionPerformed

    private void descripcionActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_descripcionActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_descripcionActionPerformed

    private void botonBorrarArticuloActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonBorrarArticuloActionPerformed
        // TODO add your handling code here:
        boolean sentencia = false;
        
        sentencia = baseDatos.ejecutar("DELETE FROM PRODUCTOS WHERE ID_PRODUCTO ='"+campoID.getText() +"'" );
        JOptionPane.showMessageDialog(null, "Producto Borrado");
        System.out.println("DELETE FROM PRODUCTOS WHERE ID_PRODUCTO ='"+campoID.getText() +"'");
        JOptionPane.showMessageDialog(null,"Articulo registrado",null, JOptionPane.INFORMATION_MESSAGE);


    }//GEN-LAST:event_botonBorrarArticuloActionPerformed

    private void valorBusquedaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_valorBusquedaActionPerformed
         // TODO add your handling code here:
    }//GEN-LAST:event_valorBusquedaActionPerformed

    private void campoIDActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_campoIDActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_campoIDActionPerformed

    private void campoIDKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoIDKeyReleased
         validarModificar();
         validarBorrar();
         validarAgregar();
    }//GEN-LAST:event_campoIDKeyReleased

    private void campoNombreArticuloKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoNombreArticuloKeyReleased
         validarModificar();
         validarAgregar();
    }//GEN-LAST:event_campoNombreArticuloKeyReleased

    private void descripcionKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_descripcionKeyReleased
         validarModificar();
         validarAgregar();
    }//GEN-LAST:event_descripcionKeyReleased

    private void campoPrecioArticuloKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoPrecioArticuloKeyReleased
         validarModificar();
         validarAgregar();
    }//GEN-LAST:event_campoPrecioArticuloKeyReleased

    private void campoCantidadActualKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoCantidadActualKeyReleased
         validarModificar();
         validarAgregar();
    }//GEN-LAST:event_campoCantidadActualKeyReleased

    private void campoCantidadSeguridadKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoCantidadSeguridadKeyReleased
         validarModificar();
         validarAgregar();
    }//GEN-LAST:event_campoCantidadSeguridadKeyReleased

    private void valorBusquedaKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_valorBusquedaKeyReleased
        validarBuscar();
    }//GEN-LAST:event_valorBusquedaKeyReleased

    private void botonBorrarArticuloKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_botonBorrarArticuloKeyReleased
        // TODO add your handling code here:
    }//GEN-LAST:event_botonBorrarArticuloKeyReleased

    private void valorBusquedaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_valorBusquedaKeyTyped
        if(valorBusqueda.getText().length() >= 10)
    {
        evt.consume();
    }
    }//GEN-LAST:event_valorBusquedaKeyTyped

    private void campoIDKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoIDKeyTyped
        if(campoID.getText().length() >= 4)
    {
        evt.consume();
    }
    }//GEN-LAST:event_campoIDKeyTyped

    private void campoNombreArticuloKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoNombreArticuloKeyTyped
        if(campoNombreArticulo.getText().length() >= 30)
    {
        evt.consume();
    }
    }//GEN-LAST:event_campoNombreArticuloKeyTyped

    private void descripcionKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_descripcionKeyTyped
        if(descripcion.getText().length() >= 40)
    {
        evt.consume();
    }
    }//GEN-LAST:event_descripcionKeyTyped

    private void campoPrecioArticuloKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoPrecioArticuloKeyTyped
        if(campoPrecioArticulo.getText().length() >= 6)
    {
        evt.consume();
    }
    }//GEN-LAST:event_campoPrecioArticuloKeyTyped

    private void campoCantidadActualKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoCantidadActualKeyTyped
       if(campoCantidadActual.getText().length() >= 4)
    {
        evt.consume();
    }// TODO add your handling code here:
    }//GEN-LAST:event_campoCantidadActualKeyTyped

    private void campoCantidadSeguridadKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_campoCantidadSeguridadKeyTyped
        if(campoCantidadSeguridad.getText().length() >= 4)
    {
        evt.consume();
    }// TODO add your handling code here:
    }//GEN-LAST:event_campoCantidadSeguridadKeyTyped

    private void botonBorrarArticuloKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_botonBorrarArticuloKeyPressed
        JOptionPane.showMessageDialog(null, "Seguro que quieres borrar?");
    }//GEN-LAST:event_botonBorrarArticuloKeyPressed


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
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f6_gestionarInventario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
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
                new f6_gestionarInventario().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonBorrarArticulo;
    private javax.swing.JButton botonBusquedaArticuloGI;
    private javax.swing.JButton botonDarDeAltaArticulo;
    private javax.swing.JButton botonModificarArticulo;
    private javax.swing.JButton botonRegresarAMenu;
    private javax.swing.JTextField campoCantidadActual;
    private javax.swing.JTextField campoCantidadSeguridad;
    private javax.swing.JTextField campoID;
    private javax.swing.JTextField campoNombreArticulo;
    private javax.swing.JTextField campoPrecioArticulo;
    private javax.swing.JPanel contenedorFormGestionarInventario;
    private javax.swing.JTextField descripcion;
    private javax.swing.JLabel etiquetaBusquedaPor;
    private javax.swing.JComboBox<String> filtroDeBusqueda;
    private javax.swing.JLabel fondoGI;
    private javax.swing.JLabel lblactual;
    private javax.swing.JLabel lblarticulo;
    private javax.swing.JLabel lbldescripcion;
    private javax.swing.JLabel lblid;
    private javax.swing.JLabel lblprecio;
    private javax.swing.JLabel lblseguridad;
    private javax.swing.JTable tablaDeInventario;
    private javax.swing.JScrollPane tablaInventarioDeArticulos;
    private javax.swing.JTextField valorBusqueda;
    // End of variables declaration//GEN-END:variables
}
