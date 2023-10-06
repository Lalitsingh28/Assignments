package com.assignment;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.stereotype.Component;
import org.springframework.web.client.RestTemplate;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.EnableWebMvc;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

@Configuration
@EnableWebMvc
@Component
public class CorsConfig implements WebMvcConfigurer {
	
	@Value("${apiKey}")
	private String apiKey;

    @Override
    public void addCorsMappings(CorsRegistry registry) {
        registry.addMapping("/api/**")
            .allowedOrigins("http://localhost:3000") // Replace with your React frontend URL
            .allowedMethods("GET", "POST")
            .allowedHeaders("*");
    }
    
    
    @Bean
    public RestTemplate getTemplate() {
    	
    	RestTemplate restTemplate = new RestTemplate();
    	restTemplate.getInterceptors().add((request,body,execution)->{
    		request.getHeaders().add("Authorization", "Bearer "+ apiKey);
    		return execution.execute(request, body);
    	});
    	
    	return restTemplate;
    	
    }
    
}
